using Natrix.TailwindCss;

namespace Natrix.Docs.Client;

public static partial class Styles
{
    [GeneratedTailwindCss(
        """
        @import "tailwindcss";
        """,
        "tailwindcss", TailwindCssDefaults.IndexCss)]
    public static partial string GetCss();
}
