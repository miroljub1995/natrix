// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioWorklet: global::Natrix.StdWeb.Worklet, global::Natrix.JSCore.IJSObjectProxy<AudioWorklet>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorklet(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioWorklet global::Natrix.JSCore.IJSObjectProxy<AudioWorklet>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioWorklet>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MessagePort Port
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>.Get(JSObject, "port");
    }
}

#nullable disable