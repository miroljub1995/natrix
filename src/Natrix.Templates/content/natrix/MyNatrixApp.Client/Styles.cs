using Natrix.TailwindCss;

namespace MyNatrixApp.Client;

public static partial class Styles
{
    [GeneratedTailwindCss(
        """
        @import "tailwindcss";
        """,
        "tailwindcss", TailwindCssDefaults.IndexCss)]
    public static partial string GetCss();
}
