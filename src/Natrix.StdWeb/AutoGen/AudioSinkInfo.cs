// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioSinkInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioSinkInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioSinkInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioSinkInfo global::Natrix.JSCore.IJSObjectProxy<AudioSinkInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioSinkInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSinkType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSinkType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSinkType>>(JSObject, "type");
    }
}

#nullable disable