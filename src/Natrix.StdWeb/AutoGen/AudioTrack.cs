// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioTrack: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioTrack>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioTrack(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioTrack global::Natrix.JSCore.IJSObjectProxy<AudioTrack>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioTrack>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Language
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "language");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Enabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "enabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "enabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SourceBuffer? SourceBuffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.SourceBuffer>.Get(JSObject, "sourceBuffer");
    }
}

#nullable disable