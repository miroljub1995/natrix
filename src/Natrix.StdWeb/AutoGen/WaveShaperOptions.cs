// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WaveShaperOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<WaveShaperOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WaveShaperOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WaveShaperOptions global::Natrix.JSCore.IJSObjectProxy<WaveShaperOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WaveShaperOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor> Curve
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>>(JSObject, "curve");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>>(JSObject, "curve", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OverSampleType Oversample
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.OverSampleType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OverSampleType>>(JSObject, "oversample");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.OverSampleType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OverSampleType>>(JSObject, "oversample", value);
    }
}

#nullable disable