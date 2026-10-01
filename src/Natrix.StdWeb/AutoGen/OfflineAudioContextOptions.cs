// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OfflineAudioContextOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<OfflineAudioContextOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OfflineAudioContextOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OfflineAudioContextOptions global::Natrix.JSCore.IJSObjectProxy<OfflineAudioContextOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OfflineAudioContextOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NumberOfChannels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "numberOfChannels");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "numberOfChannels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Length
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "length");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "length", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required float SampleRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor> RenderSizeHint
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>>>(JSObject, "renderSizeHint");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>>>(JSObject, "renderSizeHint", value);
    }
}

#nullable disable