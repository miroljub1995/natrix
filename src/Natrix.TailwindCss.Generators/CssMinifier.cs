using System;
using System.Linq;
using NUglify;
using NUglify.Css;

namespace Natrix.TailwindCss.Generators;

/// <summary>
/// Minifies the compiled stylesheet with NUglify, standing in for the Lightning CSS
/// pass behind the Tailwind CLI's <c>--minify</c>, which is native and cannot run
/// inside the compiler.
/// </summary>
internal static class CssMinifier
{
    /// <summary>
    /// Minifies <paramref name="css"/>, or returns <see langword="false"/> with the
    /// first error when NUglify cannot parse it.
    /// </summary>
    /// <remarks>
    /// An exception is reported as an error too: escaping the generator, it would
    /// drop the method body and leave only an opaque CS8785.
    /// </remarks>
    public static bool TryMinify(string css, out string minified, out string error)
    {
        UglifyResult result;
        try
        {
            result = Uglify.Css(css, new CssSettings
            {
                // Keeps /*! ... */, which is how Tailwind writes its license banner.
                CommentMode = CssComment.Important,
            });
        }
        catch (Exception exception)
        {
            minified = css;
            error = exception.Message;
            return false;
        }

        if (result.HasErrors)
        {
            minified = css;
            error = result.Errors.First(static e => e.IsError).ToString();
            return false;
        }

        minified = result.Code;
        error = "";
        return true;
    }
}
