using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using Natrix.TailwindCss.Engine.Abstractions;

namespace Natrix.TailwindCss.Engine;

/// <summary>
/// Runs the bundled Tailwind CSS compiler inside a V8 isolate.
/// </summary>
/// <remarks>
/// Loaded by reflection from the analyzer and instantiated through
/// <see cref="Activator"/>; the analyzer only ever sees
/// <see cref="ITailwindEngine"/>.
/// <para>
/// The V8 runtime and the parsed bundle are created once and shared for the life
/// of the process; each build gets its own short-lived engine. The runtime is
/// deliberately never recycled: measured over 400 consecutive builds the isolate's
/// heap stays flat (~31-34 MB used, ~71-87 MB total), because disposing each
/// engine lets V8 reclaim its allocations and <see cref="V8RuntimeConstraints.MaxOldSpaceSize"/>
/// caps it regardless. A periodic reset was tried and removed as unjustified.
/// </para>
/// </remarks>
public sealed class TailwindEngine : ITailwindEngine
{
    /// <summary>V8ScriptEngine is not thread-safe and Roslyn runs generators concurrently.</summary>
    private static readonly object Gate = new object();

    private static V8Runtime? _runtime;
    private static V8Script? _script;
    private static string? _scriptSource;
    private static byte[]? _codeCache;

    public string Build(
        string nativeDirectory,
        string bundleJs,
        string css,
        string basePath,
        string[] candidates,
        Func<string, string, StylesheetResult> loadStylesheet)
    {
        lock (Gate)
        {
            EnsureRuntime(nativeDirectory, bundleJs);

            try
            {
                using var engine = _runtime!.CreateScriptEngine(
                    V8ScriptEngineFlags.DisableGlobalMembers |
                    V8ScriptEngineFlags.HideHostExceptions |
                    // Turns the entry point's promise into a Task, so the result
                    // is awaited rather than polled.
                    V8ScriptEngineFlags.EnableTaskPromiseConversion);

                engine.Execute(_script);

                var pending = engine.Invoke(
                    "natrixTailwindBuild", css, basePath, candidates, loadStylesheet);

                return Await(pending);
            }
            catch (Exception ex) when (ex is not TailwindEngineException and not TailwindStylesheetException)
            {
                throw new TailwindStylesheetException(Describe(ex));
            }
        }
    }

    /// <summary>
    /// Unwraps the converted promise.
    /// </summary>
    /// <remarks>
    /// Blocking here is safe precisely because nothing in the chain needs a
    /// macrotask: the promise has already settled by the time it reaches us. If a
    /// future Tailwind awaited a timer this would deadlock, which is why the
    /// entry point keeps its callbacks synchronous.
    /// </remarks>
    private static string Await(object? pending)
    {
        try
        {
            return pending switch
            {
                string css => css, // conversion disabled or already unwrapped
                Task<object> task => task.GetAwaiter().GetResult() as string
                    ?? throw new TailwindStylesheetException("Tailwind returned no CSS."),
                Task task => throw new TailwindEngineException(
                    $"The Tailwind entry point returned an unexpected {task.GetType().Name}."),
                _ => throw new TailwindEngineException(
                    $"The Tailwind entry point returned {pending?.GetType().Name ?? "null"} rather than a promise."),
            };
        }
        catch (AggregateException ex) when (ex.InnerException is not null)
        {
            throw new TailwindStylesheetException(Describe(ex.InnerException));
        }
    }

    private static void EnsureRuntime(string nativeDirectory, string bundleJs)
    {
        try
        {
            // Both are needed and both must happen before the first V8Runtime:
            // ClearScript consults the search path to decide the library is
            // present, and the resolver is what actually loads it from there.
            NativeV8Loader.Install(nativeDirectory);
            AddAuxiliarySearchPath(nativeDirectory);

            if (_runtime is null)
            {
                _runtime = new V8Runtime(new V8RuntimeConstraints { MaxOldSpaceSize = 512 });
                _scriptSource = null;
            }

            if (_script is not null && _scriptSource == bundleJs)
                return;

            _script?.Dispose();
            _script = null;

            var documentInfo = new DocumentInfo("tailwind.bundle.js");

            // Re-parsing 272 KB of Tailwind for every runtime is pure waste; V8's
            // code cache skips it.
            _script = _codeCache is { Length: > 0 }
                ? _runtime.Compile(documentInfo, bundleJs, V8CacheKind.Code, _codeCache, out _)
                : _runtime.Compile(documentInfo, bundleJs, V8CacheKind.Code, out _codeCache);

            _scriptSource = bundleJs;
        }
        catch (Exception ex)
        {
            // A half-built runtime is worse than none; drop it so the next
            // attempt starts clean.
            Reset();
            throw new TailwindEngineException(Describe(ex), ex);
        }
    }

    private static void AddAuxiliarySearchPath(string nativeDirectory)
    {
        if (string.IsNullOrEmpty(nativeDirectory))
            return;

        var existing = HostSettings.AuxiliarySearchPath;
        if (string.IsNullOrEmpty(existing))
        {
            HostSettings.AuxiliarySearchPath = nativeDirectory;
            return;
        }

        // Process-global, so other ClearScript users in the same compiler get a
        // say too: append rather than overwrite.
        var known = new HashSet<string>(
            existing!.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries), StringComparer.Ordinal);

        if (known.Add(nativeDirectory))
            HostSettings.AuxiliarySearchPath = existing + ";" + nativeDirectory;
    }

    private static void Reset()
    {
        _script?.Dispose();
        _script = null;
        _scriptSource = null;
        _runtime?.Dispose();
        _runtime = null;
    }

    private static string Describe(Exception ex)
    {
        // ScriptEngineException carries the useful V8-side detail here; plain
        // exceptions (DllNotFoundException and friends) do not.
        if (ex is ScriptEngineException { ErrorDetails.Length: > 0 } scriptEngineException)
        {
            // V8 formats a thrown Error as "Error: <message>\n    at ...". The
            // caller already prefixes its own wording, so drop the redundant tag.
            var details = scriptEngineException.ErrorDetails;
            return details.StartsWith("Error: ", StringComparison.Ordinal)
                ? details.Substring("Error: ".Length)
                : details;
        }

        return ex.InnerException is null
            ? ex.Message
            : ex.Message + " -> " + ex.InnerException.Message;
    }
}
