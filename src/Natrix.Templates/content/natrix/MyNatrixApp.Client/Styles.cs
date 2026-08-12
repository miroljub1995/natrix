using Natrix.TailwindCss;

namespace MyNatrixApp.Client;

public static partial class Styles
{
    [GeneratedTailwindCss("Styles/app.css")]
    public static partial string GetCss();

    /// <summary>Classes applied to the document body.</summary>
    /// <remarks>
    /// Declared here rather than in the server project, next to the method that
    /// compiles the stylesheet, because the generator collects candidate class
    /// names from the string literals of the compilation it runs in. A class
    /// named only in the server project is never seen, so no utility is emitted
    /// for it and the style silently does not apply.
    /// </remarks>
    public const string Body = "bg-white dark:bg-gray-950 text-gray-900 dark:text-gray-100";
}
