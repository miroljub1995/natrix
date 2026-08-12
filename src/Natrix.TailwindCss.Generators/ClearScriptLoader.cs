using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Natrix.TailwindCss.Generators;

/// <summary>
/// Resolves the Tailwind engine assembly and its ClearScript dependencies out of
/// the package payload directory.
/// </summary>
/// <remarks>
/// The analyzer runs in whichever process the compiler host happens to be:
/// <c>VBCSCompiler</c> on modern .NET for <c>dotnet build</c>, Rider and VS Code,
/// or <c>devenv.exe</c>/<c>MSBuild.exe</c> on .NET Framework for Visual Studio.
/// ClearScript ships a different assembly for each, and neither can be loaded by
/// the other runtime, so both are packaged and the right one is picked here.
/// None of these assemblies live under <c>analyzers/</c>: Roslyn would treat them
/// as analyzers and complain that they cannot be loaded.
/// </remarks>
internal static class ClearScriptLoader
{
    private static int _installed;
    private static string _engineDir = "";

    /// <summary>
    /// The AssemblyLoadContext we hooked, or null on .NET Framework. Everything
    /// must load through this one context: loading the engine anywhere else would
    /// put its ClearScript dependencies out of reach of the hook installed below.
    /// </summary>
    private static object? _loadContext;

    /// <summary>The flavor subdirectory matching the runtime we are hosted in.</summary>
    private static string Flavor =>
        RuntimeInformation.FrameworkDescription.StartsWith(".NET Framework", StringComparison.Ordinal)
            ? "net462"
            : "net8.0";

    /// <summary>
    /// Installs the resolve hook. Safe to call repeatedly; only the first call
    /// does anything.
    /// </summary>
    internal static void Install(string payloadDir)
    {
        if (Interlocked.Exchange(ref _installed, 1) != 0)
            return;

        _engineDir = Path.Combine(payloadDir, "engine");

        var loadContextType = Type.GetType(
                "System.Runtime.Loader.AssemblyLoadContext, System.Runtime.Loader", throwOnError: false)
            ?? Type.GetType(
                "System.Runtime.Loader.AssemblyLoadContext, System.Private.CoreLib", throwOnError: false);

        if (loadContextType is null)
        {
            // .NET Framework host.
            AppDomain.CurrentDomain.AssemblyResolve += static (_, args) => Resolve(args.Name, null);
            return;
        }

        // Modern .NET host. Load into the analyzer's own context so the engine
        // sees the same System.Private.CoreLib we do and `Func<...>` unifies
        // across the reflection call.
        var context =
            loadContextType.GetMethod("GetLoadContext", BindingFlags.Public | BindingFlags.Static)
                ?.Invoke(null, new object[] { typeof(ClearScriptLoader).Assembly })
            ?? loadContextType.GetProperty("Default", BindingFlags.Public | BindingFlags.Static)?.GetValue(null);

        if (context is null)
            return;

        _loadContext = context;

        var resolving = loadContextType.GetEvent("Resolving");
        var handler = typeof(ClearScriptLoader)
            .GetMethod(nameof(OnResolving), BindingFlags.NonPublic | BindingFlags.Static);

        if (resolving?.EventHandlerType is null || handler is null)
            return;

        // Relaxed delegate binding: the event wants
        // Func<AssemblyLoadContext, AssemblyName, Assembly> and reference-type
        // parameters are contravariant, so an `object` first parameter binds.
        resolving.AddEventHandler(context, Delegate.CreateDelegate(resolving.EventHandlerType, handler));
    }

    /// <summary>Loads the engine assembly, or null when the payload is missing.</summary>
    internal static Assembly? LoadEngine()
    {
        var path = Probe("Natrix.TailwindCss.Engine");
        return path is null ? null : Load(path);
    }

    private static Assembly? OnResolving(object context, AssemblyName name) => Resolve(name.FullName, context);

    /// <summary>
    /// Serves any assembly we happen to ship, rather than matching a fixed list.
    /// </summary>
    /// <remarks>
    /// The payload is whatever the engine's dependency closure turned out to be:
    /// ClearScript, Newtonsoft.Json, and on .NET Framework a set of
    /// System.*/Microsoft.Bcl.* facades. Enumerating those by hand is how they
    /// get forgotten. Probing by name is safe because the flavor directory only
    /// ever contains assemblies we put there, and returning null falls back to
    /// the host's own resolution.
    /// </remarks>
    private static Assembly? Resolve(string fullName, object? context)
    {
        var simpleName = new AssemblyName(fullName).Name;
        if (simpleName is null)
            return null;

        var path = Probe(simpleName);
        return path is null ? null : Load(path);
    }

    private static string? Probe(string simpleName)
    {
        if (_engineDir.Length == 0)
            return null;

        // The flavor directory first, then its parent for the flavor-neutral ICU
        // data assembly (netstandard1.0, one copy for both hosts).
        string[] directories = { Path.Combine(_engineDir, Flavor), _engineDir };

        foreach (var directory in directories)
        {
            var path = Path.Combine(directory, simpleName + ".dll");
            if (File.Exists(path))
                return path;
        }

        return null;
    }

    private static Assembly? Load(string path)
    {
        if (_loadContext is null)
            return Assembly.LoadFrom(path);

        return _loadContext.GetType()
            .GetMethod("LoadFromAssemblyPath", new[] { typeof(string) })
            ?.Invoke(_loadContext, new object[] { path }) as Assembly;
    }
}
