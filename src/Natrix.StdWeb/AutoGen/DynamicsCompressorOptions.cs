// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DynamicsCompressorOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<DynamicsCompressorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DynamicsCompressorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DynamicsCompressorOptions global::Natrix.JSCore.IJSObjectProxy<DynamicsCompressorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DynamicsCompressorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Attack
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "attack");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "attack", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Knee
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "knee");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "knee", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Ratio
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "ratio");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "ratio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Release
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "release");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "release", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Threshold
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "threshold");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "threshold", value);
    }
}

#nullable disable