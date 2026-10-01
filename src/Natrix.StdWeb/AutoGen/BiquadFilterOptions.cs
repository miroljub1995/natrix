// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BiquadFilterOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<BiquadFilterOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BiquadFilterOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BiquadFilterOptions global::Natrix.JSCore.IJSObjectProxy<BiquadFilterOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BiquadFilterOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BiquadFilterType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BiquadFilterType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BiquadFilterType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Q
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "Q");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "Q", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Detune
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "detune");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "detune", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Frequency
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "frequency");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "frequency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Gain
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "gain");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "gain", value);
    }
}

#nullable disable