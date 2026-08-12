using System;
using System.IO;

namespace Natrix.TailwindCss.Generators;

/// <summary>
/// The bundled Tailwind compiler, embedded in this assembly.
/// </summary>
/// <remarks>
/// Only the JavaScript is embedded. Tailwind's stylesheets ship as real files
/// under <c>tools/tailwind/css/</c> and reach the generator as AdditionalFiles
/// like any other stylesheet, so they are resolved by the same code path as a
/// project's own CSS. Refresh both with
/// <c>cd js &amp;&amp; npm ci &amp;&amp; npm run bundle</c>.
/// </remarks>
internal static class TailwindResources
{
    private const string ResourceName = "Natrix.TailwindCss.Generators.tailwind.bundle.js";

    private static readonly Lazy<string> LazyBundleJs = new(Read);

    /// <summary>The bundled Tailwind compiler, as plain JavaScript for a bare V8 isolate.</summary>
    public static string BundleJs => LazyBundleJs.Value;

    private static string Read()
    {
        using var stream = typeof(TailwindResources).Assembly.GetManifestResourceStream(ResourceName)
            ?? throw new InvalidOperationException($"Embedded resource '{ResourceName}' is missing.");
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}
