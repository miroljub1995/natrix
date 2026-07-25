// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioWorkletProcessor: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorkletProcessor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AudioWorkletProcessor New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AudioWorkletProcessor");
        return new global::Natrix.StdWeb.AudioWorkletProcessor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MessagePort Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port");
    }
}

#nullable disable