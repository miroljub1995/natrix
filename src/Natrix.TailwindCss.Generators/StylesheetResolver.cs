using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Natrix.TailwindCss.Engine.Abstractions;

namespace Natrix.TailwindCss.Generators;

/// <summary>A stylesheet visible to the compiler, keyed by its absolute path.</summary>
/// <param name="Path">
/// Absolute, normalized to forward slashes. Absolute rather than project-relative
/// because it is the only form every stylesheet can share: an AdditionalFile may
/// live outside the project, and a package's stylesheets always do.
/// </param>
/// <param name="Content">The file's text.</param>
/// <param name="Module">
/// Comma-separated module ids this file is exported as, from the
/// <c>TailwindModule</c> metadata on its <c>AdditionalFiles</c> item, or
/// <see langword="null"/> when the item carries no such metadata. Whitespace
/// around an id is trimmed, as MSBuild trims an item spec.
/// <para>
/// The separator is a comma, not MSBuild's usual semicolon, because this metadata
/// reaches the compiler through an editorconfig, and Roslyn's reader strips
/// <c>;</c> and <c>#</c> as inline comments - the value is truncated there before
/// the generator ever sees it. An id can contain neither character.
/// </para>
/// </param>
internal readonly record struct Stylesheet(string Path, string Content, string? Module);

/// <summary>
/// Resolves <c>@import</c> specifiers against the project's stylesheets.
/// </summary>
/// <remarks>
/// This never touches the filesystem. Everything comes from the AdditionalFiles
/// snapshot Roslyn handed the generator, which is exactly what makes the
/// generator incremental: a stylesheet that is read here is a stylesheet Roslyn
/// knows to watch, so editing it re-runs the compilation.
/// <para>
/// Resolution is purely a function of the arguments: a specifier is resolved
/// against the <c>base</c> Tailwind passes back, which is the directory of the
/// stylesheet doing the importing. The resolver holds no ambient directory of its
/// own, so where a file sits relative to the project never enters into it.
/// </para>
/// <para>
/// Tailwind's own stylesheets are not special-cased. They are supplied as
/// AdditionalFiles like everything else, with <c>TailwindModule="tailwindcss"</c>
/// on the entry file, so any CSS package can be wired up the same way.
/// </para>
/// </remarks>
internal sealed class StylesheetResolver
{
    /// <summary>
    /// Path comparison follows the host filesystem: case-sensitive on Linux,
    /// case-insensitive on Windows and macOS.
    /// </summary>
    private static readonly bool CaseSensitive = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

    private static readonly StringComparer PathComparer =
        CaseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;

    private readonly Dictionary<string, string> _stylesheets;

    /// <summary>Module id to the path of its entry stylesheet.</summary>
    private readonly Dictionary<string, string> _modules;

    private readonly List<string> _served = new();

    public StylesheetResolver(EquatableArray<Stylesheet> stylesheets)
    {
        _stylesheets = new Dictionary<string, string>(PathComparer);
        _modules = new Dictionary<string, string>(StringComparer.Ordinal);

        foreach (var stylesheet in stylesheets)
        {
            _stylesheets[stylesheet.Path] = stylesheet.Content;

            if (stylesheet.Module is null)
                continue;

            // One file may be exported under several ids, the way a package's
            // exports map aliases "./theme" and "./theme.css" to one stylesheet.
            //
            // Comma separates; whitespace around an id is only trimmed. That
            // mirrors how MSBuild tokenizes an item list - separator, then trim -
            // so a value wrapped across lines in the XML still reads as the list
            // it was written as. The separator is a comma rather than MSBuild's
            // semicolon because this metadata reaches the generator through an
            // editorconfig, whose reader truncates a value at ";" or "#".
            foreach (var id in stylesheet.Module.Split(','))
            {
                var trimmed = id.Trim();
                if (trimmed.Length > 0)
                    _modules[trimmed] = stylesheet.Path;
            }
        }
    }

    /// <summary>Contents of the stylesheets actually pulled in by the last compilation.</summary>
    public IReadOnlyList<string> Served => _served;

    public bool TryGet(string path, out string content) =>
        _stylesheets.TryGetValue(Normalize(path), out content!);

    /// <summary>
    /// The callback handed to Tailwind. Reports failure in the result rather than
    /// throwing, so it surfaces as a JavaScript error Tailwind can attribute
    /// instead of a .NET exception unwinding through the engine.
    /// </summary>
    public StylesheetResult Load(string id, string basePath)
    {
        // Relative first, modules second. That is the order @tailwindcss/vite
        // uses: its CSS resolver is created with preferRelative, and Tailwind
        // consults it before the node_modules lookup. So a file sitting next to
        // the importer wins over a package of the same name - a project that
        // really does have its own Styles/tailwindcss.css gets that file.
        foreach (var candidate in RelativePaths(id, basePath))
        {
            if (TryServe(candidate, out var result))
                return result;
        }

        if (_modules.TryGetValue(id, out var moduleEntry) && TryServe(moduleEntry, out var moduleResult))
            return moduleResult;

        return StylesheetResult.NotFound(
            $"Could not resolve the import '{id}' from '{basePath}'. " +
            "Stylesheets are the ones the project lists as AdditionalFiles; add an " +
            "<AdditionalFiles Include=\"...\" /> item for this file, or give a package's " +
            "entry stylesheet TailwindModule=\"...\" metadata to expose it as a module.");
    }

    private bool TryServe(string path, out StylesheetResult result)
    {
        if (!_stylesheets.TryGetValue(path, out var content))
        {
            result = default!;
            return false;
        }

        _served.Add(content);

        // The base is the resolved file's own directory, so its relative imports
        // resolve from where it lives rather than from the project root. That is
        // what lets a module reference its siblings.
        result = StylesheetResult.Found(path, DirectoryOf(path), content);
        return true;
    }

    /// <summary>Paths to try for an ordinary relative or absolute specifier.</summary>
    private static IEnumerable<string> RelativePaths(string id, string basePath) =>
        Variants(Resolve(basePath, id));

    /// <summary>
    /// Resolves a specifier against the directory that is importing it. An
    /// already-absolute specifier is taken as it stands; everything else is
    /// relative, including a bare one, because plain CSS has no other reading.
    /// </summary>
    internal static string Resolve(string basePath, string specifier)
    {
        var normalized = specifier.Replace('\\', '/');

        return Normalize(normalized.StartsWith("/", StringComparison.Ordinal)
            ? normalized
            : Combine(basePath, normalized));
    }

    private static IEnumerable<string> Variants(string root)
    {
        yield return root;
        yield return root + ".css";
        yield return root + "/index.css";
    }

    private static string Combine(string basePath, string specifier) =>
        string.IsNullOrEmpty(basePath) ? specifier : basePath.TrimEnd('/') + "/" + specifier;

    /// <summary>
    /// Collapses <c>.</c> and <c>..</c> segments lexically. Never
    /// <c>Path.GetFullPath</c>: that would anchor relative paths to the compiler
    /// process's working directory, which has nothing to do with the project.
    /// </summary>
    internal static string Normalize(string path)
    {
        var normalized = path.Replace('\\', '/');
        // A stylesheet outside the project directory keeps its absolute path;
        // the leading separator is part of it.
        var rooted = normalized.StartsWith("/", StringComparison.Ordinal);

        var segments = normalized.Split('/');
        var stack = new List<string>(segments.Length);

        foreach (var segment in segments)
        {
            switch (segment)
            {
                case "" or ".":
                    break;
                case "..":
                    if (stack.Count > 0 && stack[stack.Count - 1] != "..")
                        stack.RemoveAt(stack.Count - 1);
                    else
                        stack.Add("..");
                    break;
                default:
                    stack.Add(segment);
                    break;
            }
        }

        var result = string.Join("/", stack.ToArray());
        return rooted ? "/" + result : result;
    }

    /// <summary>The directory a stylesheet lives in, which is the base for its own imports.</summary>
    internal static string DirectoryOf(string path)
    {
        var index = path.LastIndexOf('/');
        return index < 0 ? "" : path.Substring(0, index);
    }
}
