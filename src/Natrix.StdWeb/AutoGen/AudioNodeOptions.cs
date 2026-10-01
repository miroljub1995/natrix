// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioNodeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioNodeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioNodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioNodeOptions global::Natrix.JSCore.IJSObjectProxy<AudioNodeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioNodeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ChannelCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "channelCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "channelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ChannelCountMode ChannelCountMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ChannelCountMode>.Get(JSObject, "channelCountMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ChannelCountMode>.Set(JSObject, "channelCountMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ChannelInterpretation ChannelInterpretation
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ChannelInterpretation>.Get(JSObject, "channelInterpretation");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ChannelInterpretation>.Set(JSObject, "channelInterpretation", value);
    }
}

#nullable disable