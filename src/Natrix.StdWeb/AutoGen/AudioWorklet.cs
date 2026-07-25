// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioWorklet: global::Natrix.StdWeb.Worklet
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorklet(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MessagePort Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port");
    }
}

#nullable disable