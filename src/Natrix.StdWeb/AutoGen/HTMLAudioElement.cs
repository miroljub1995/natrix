// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLAudioElement: global::Natrix.StdWeb.HTMLMediaElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLAudioElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLAudioElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLAudioElement");
        return new global::Natrix.StdWeb.HTMLAudioElement(___res_2);
    }
}

#nullable disable