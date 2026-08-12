using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Natrix.TailwindCss.Engine.Abstractions;

namespace Natrix.TailwindCss.Generators;

/// <summary>The outcome of a Tailwind compilation.</summary>
internal readonly struct CompileResult
{
    private CompileResult(CompileStatus status, string payload)
    {
        Status = status;
        Payload = payload;
    }

    public CompileStatus Status { get; }

    /// <summary>The compiled CSS on success, otherwise the error message.</summary>
    public string Payload { get; }

    public static CompileResult Success(string css) => new(CompileStatus.Success, css);

    public static CompileResult StylesheetError(string message) => new(CompileStatus.StylesheetError, message);

    public static CompileResult EngineError(string message) => new(CompileStatus.EngineError, message);
}

internal enum CompileStatus
{
    Success,

    /// <summary>Tailwind rejected the input: bad CSS, unresolved import, unsupported plugin.</summary>
    StylesheetError,

    /// <summary>V8 could not be loaded or initialised on this machine.</summary>
    EngineError,
}

/// <summary>
/// Calls the Tailwind engine, which lives in a separate assembly loaded by
/// reflection.
/// </summary>
/// <remarks>
/// Reflection is used exactly once, to construct the engine; everything after
/// that goes through <see cref="ITailwindEngine"/>. The analyzer never names a
/// ClearScript type, which is what keeps it loadable on both compiler hosts.
/// </remarks>
internal static class TailwindCompiler
{
    private const string EngineTypeName = "Natrix.TailwindCss.Engine.TailwindEngine";

    private static readonly object Gate = new();

    private static ITailwindEngine? _engine;
    private static string? _engineLoadError;

    /// <summary>
    /// Compiles <paramref name="css"/> into a stylesheet containing the utilities
    /// used by <paramref name="candidates"/>.
    /// </summary>
    public static CompileResult Compile(
        string payloadDir,
        string css,
        string basePath,
        IReadOnlyList<string> candidates,
        Func<string, string, StylesheetResult> loadStylesheet)
    {
        lock (Gate)
        {
            try
            {
                var css2 = GetEngine(payloadDir).Build(
                    NativeDirectory(payloadDir),
                    TailwindResources.BundleJs,
                    css,
                    basePath,
                    candidates as string[] ?? candidates.ToArray(),
                    loadStylesheet);

                return CompileResult.Success(css2);
            }
            catch (TailwindStylesheetException ex)
            {
                return CompileResult.StylesheetError(ex.Message);
            }
            catch (TailwindEngineException ex)
            {
                return CompileResult.EngineError(ex.Message);
            }
            catch (Exception ex)
            {
                return CompileResult.EngineError(Describe(ex));
            }
        }
    }

    private static ITailwindEngine GetEngine(string payloadDir)
    {
        if (_engine is not null)
            return _engine;

        // A missing payload fails the same way every time; remember it rather
        // than probing the filesystem once per attributed method per keystroke.
        if (_engineLoadError is not null)
            throw new TailwindEngineException(_engineLoadError);

        try
        {
            ClearScriptLoader.Install(payloadDir);

            var assembly = ClearScriptLoader.LoadEngine()
                ?? throw new TailwindEngineException(
                    $"The Tailwind CSS engine was not found under '{payloadDir}'.");

            var type = assembly.GetType(EngineTypeName)
                ?? throw new TailwindEngineException(
                    $"'{EngineTypeName}' was not found in {assembly.FullName}.");

            _engine = (ITailwindEngine)Activator.CreateInstance(type);
            return _engine;
        }
        catch (Exception ex)
        {
            _engineLoadError = Describe(ex);
            throw new TailwindEngineException(_engineLoadError, ex);
        }
    }

    private static string NativeDirectory(string payloadDir) =>
        Path.Combine(payloadDir, "runtimes", GetRuntimeIdentifier(), "native");

    /// <summary>The RID whose native V8 library this process can load.</summary>
    internal static string GetRuntimeIdentifier()
    {
        var arm64 = RuntimeInformation.ProcessArchitecture == Architecture.Arm64;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return arm64 ? "osx-arm64" : "osx-x64";

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return arm64 ? "linux-arm64" : "linux-x64";

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Windows on ARM runs x64 processes under emulation, and
            // ProcessArchitecture reports what the process actually is, so an
            // emulated compiler host correctly asks for win-x64.
            return arm64 ? "win-arm64" : "win-x64";
        }

        throw new PlatformNotSupportedException(
            $"Tailwind CSS compilation is not supported on {RuntimeInformation.OSDescription}.");
    }

    private static string Describe(Exception ex) =>
        ex.InnerException is null ? ex.Message : ex.Message + " -> " + ex.InnerException.Message;
}
