using System;

namespace Natrix.TailwindCss.Engine.Abstractions;

/// <summary>
/// Runs the bundled Tailwind compiler.
/// </summary>
/// <remarks>
/// Implemented by the engine assembly, which is loaded by reflection because the
/// analyzer cannot reference it directly. Instantiate through
/// <see cref="Activator"/> and cast to this interface.
/// </remarks>
public interface ITailwindEngine
{
    /// <summary>Compiles a stylesheet and emits the utilities the candidates use.</summary>
    /// <param name="nativeDirectory">Directory holding the native V8 library for this RID.</param>
    /// <param name="bundleJs">The bundled Tailwind compiler source.</param>
    /// <param name="css">The entry stylesheet's contents.</param>
    /// <param name="basePath">Directory of the entry stylesheet, for resolving relative imports.</param>
    /// <param name="candidates">Class names to generate utilities for.</param>
    /// <param name="loadStylesheet">Resolves an <c>@import</c>. Takes (id, base). Must not throw.</param>
    /// <exception cref="TailwindEngineException">V8 could not be initialized on this machine.</exception>
    /// <exception cref="TailwindStylesheetException">Tailwind rejected the stylesheet.</exception>
    string Build(
        string nativeDirectory,
        string bundleJs,
        string css,
        string basePath,
        string[] candidates,
        Func<string, string, StylesheetResult> loadStylesheet);
}

/// <summary>
/// The answer to an <c>@import</c>.
/// </summary>
/// <remarks>
/// Crosses into JavaScript as a host object, which is why it carries the failure
/// instead of throwing: a .NET exception thrown inside a V8 callback unwinds
/// through the engine rather than becoming a JavaScript error Tailwind can report.
/// <para>
/// It lives in the contract assembly so both sides see one type identity.
/// </para>
/// </remarks>
public sealed class StylesheetResult
{
    private StylesheetResult(string? path, string? basePath, string? content, string? error)
    {
        Path = path;
        Base = basePath;
        Content = content;
        Error = error;
    }

    public string? Path { get; }

    public string? Base { get; }

    public string? Content { get; }

    /// <summary>Non-null when the import could not be resolved.</summary>
    public string? Error { get; }

    public static StylesheetResult Found(string path, string basePath, string content) =>
        new(path, basePath, content, null);

    public static StylesheetResult NotFound(string error) => new(null, null, null, error);
}

/// <summary>The engine itself could not run — a missing payload or an unloadable native library.</summary>
public class TailwindEngineException : Exception
{
    public TailwindEngineException(string message) : base(message) { }

    public TailwindEngineException(string message, Exception innerException)
        : base(message, innerException) { }
}

/// <summary>Tailwind rejected the input: bad CSS, an unresolved import, an unsupported plugin.</summary>
public class TailwindStylesheetException : Exception
{
    public TailwindStylesheetException(string message) : base(message) { }
}
