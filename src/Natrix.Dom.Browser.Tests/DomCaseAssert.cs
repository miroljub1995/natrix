using Natrix.Dom.TestCases;

namespace Natrix.Dom.Browser.Tests;

internal static class DomCaseAssert
{
    public static async Task RendersAsync(DomCase c)
    {
        Skip.When(c.BrowserIssue is not null, c.BrowserIssue!);

        var (container, host) = DomRenderer.Mount(c.Create);
        using (host)
        {
            await Assert.That(DomRenderer.Serialize(container)).IsEqualTo(c.BrowserHtml ?? c.Html);

            if (c.Property is var (name, expected))
            {
                await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, name)).IsEqualTo(expected);
            }
        }
    }
}
