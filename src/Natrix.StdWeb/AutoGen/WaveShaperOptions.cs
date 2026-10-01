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
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Get(JSObject, "curve");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Set(JSObject, "curve", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OverSampleType Oversample
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OverSampleType>.Get(JSObject, "oversample");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OverSampleType>.Set(JSObject, "oversample", value);
    }
}

#nullable disable