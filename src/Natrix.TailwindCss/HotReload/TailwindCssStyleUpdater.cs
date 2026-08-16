namespace Natrix.TailwindCss;

/// <summary>
/// Keeps a rendered stylesheet in sync with a generated one across hot reload deltas.
/// </summary>
/// <remarks>
/// Wired up for you by <see cref="NatrixHostBuilderTailwindCssExtensions.UseTailwindCssHotReload"/>,
/// which applies the stylesheet by writing it to a <c>&lt;style&gt;</c> element. Kept free of the
/// DOM so the decision of whether to write at all — the part that matters — stands on its own.
/// </remarks>
public sealed class TailwindCssStyleUpdater
{
    private readonly Func<string> _getCss;
    private readonly Action<string> _applyCss;

    private string _current;

    /// <param name="getCss">
    /// The generated method, e.g. <c>Styles.GetCss</c>. Hot reload replaces method bodies in place,
    /// so a delegate captured once keeps returning the current stylesheet.
    /// </param>
    /// <param name="applyCss">Called with the new stylesheet whenever it changes.</param>
    /// <param name="current">
    /// The stylesheet already applied, if it is known to differ from <paramref name="getCss"/>'s
    /// current value. Defaults to that value, which is the normal case: the server rendered the
    /// stylesheet this same assembly generated, so the first delta that leaves it alone writes
    /// nothing.
    /// </param>
    public TailwindCssStyleUpdater(Func<string> getCss, Action<string> applyCss, string? current = null)
    {
        _getCss = getCss;
        _applyCss = applyCss;
        _current = current ?? getCss();
    }

    /// <summary>
    /// Re-reads the stylesheet and applies it when it differs from the last one applied.
    /// </summary>
    public void Refresh()
    {
        var css = _getCss();

        if (string.Equals(css, _current, StringComparison.Ordinal))
        {
            return;
        }

        _current = css;
        _applyCss(css);

        Console.WriteLine("[HotReload] Updated Tailwind CSS");
    }
}
