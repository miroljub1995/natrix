namespace Natrix.TailwindCss.Tests;

public class TailwindCssStyleUpdaterTests
{
    [Test]
    public async Task Applies_regenerated_stylesheet()
    {
        var css = ".flex{display:flex}";
        string? applied = null;

        var updater = new TailwindCssStyleUpdater(() => css, value => applied = value);

        css = ".flex{display:flex}.hidden{display:none}";
        updater.Refresh();

        await Assert.That(applied).IsEqualTo(css);
    }

    [Test]
    public async Task Does_not_apply_an_unchanged_stylesheet()
    {
        // Deltas arrive for every edit, not just the ones that reach the stylesheet. Writing
        // regardless would reparse it and force a full style recalculation on each of them.
        var css = ".flex{display:flex}";
        var applyCount = 0;

        var updater = new TailwindCssStyleUpdater(() => css, _ => applyCount++);

        updater.Refresh();
        updater.Refresh();

        await Assert.That(applyCount).IsEqualTo(0);
    }

    [Test]
    public async Task Applies_once_per_change()
    {
        var css = ".flex{display:flex}";
        var applyCount = 0;

        var updater = new TailwindCssStyleUpdater(() => css, _ => applyCount++);

        css = ".hidden{display:none}";
        updater.Refresh();
        updater.Refresh();

        await Assert.That(applyCount).IsEqualTo(1);
    }

    [Test]
    public async Task Applies_when_the_rendered_stylesheet_is_known_to_be_stale()
    {
        var css = ".flex{display:flex}";
        string? applied = null;

        var updater = new TailwindCssStyleUpdater(() => css, value => applied = value, current: "");

        updater.Refresh();

        await Assert.That(applied).IsEqualTo(css);
    }
}
