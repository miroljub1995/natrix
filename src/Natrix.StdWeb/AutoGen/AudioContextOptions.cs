// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioContextOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioContextOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioContextOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioContextOptions global::Natrix.JSCore.IJSObjectProxy<AudioContextOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioContextOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextLatencyCategory, double, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextLatencyCategory>, global::Natrix.JSCore.Generics.DoubleAccessor> LatencyHint
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextLatencyCategory, double, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextLatencyCategory>, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextLatencyCategory, double, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextLatencyCategory>, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "latencyHint");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextLatencyCategory, double, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextLatencyCategory>, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextLatencyCategory, double, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextLatencyCategory>, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "latencyHint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float SampleRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.AudioSinkOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioSinkOptions>> SinkId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.AudioSinkOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioSinkOptions>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.AudioSinkOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioSinkOptions>>>>(JSObject, "sinkId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.AudioSinkOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioSinkOptions>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.AudioSinkOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioSinkOptions>>>>(JSObject, "sinkId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor> RenderSizeHint
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>>>(JSObject, "renderSizeHint");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AudioContextRenderSizeCategory, uint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioContextRenderSizeCategory>, global::Natrix.JSCore.Generics.UInt32Accessor>>>(JSObject, "renderSizeHint", value);
    }
}

#nullable disable