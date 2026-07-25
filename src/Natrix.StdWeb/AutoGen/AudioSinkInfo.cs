// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioSinkInfo: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioSinkInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSinkType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSinkType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
    }
}

#nullable disable