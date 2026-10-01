// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PannerOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<PannerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PannerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PannerOptions global::Natrix.JSCore.IJSObjectProxy<PannerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PannerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PanningModelType PanningModel
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PanningModelType>.Get(JSObject, "panningModel");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PanningModelType>.Set(JSObject, "panningModel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DistanceModelType DistanceModel
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DistanceModelType>.Get(JSObject, "distanceModel");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DistanceModelType>.Set(JSObject, "distanceModel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float PositionX
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "positionX");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "positionX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float PositionY
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "positionY");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "positionY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float PositionZ
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "positionZ");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "positionZ", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float OrientationX
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "orientationX");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "orientationX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float OrientationY
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "orientationY");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "orientationY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float OrientationZ
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "orientationZ");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "orientationZ", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RefDistance
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "refDistance");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "refDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxDistance
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxDistance");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "maxDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RolloffFactor
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "rolloffFactor");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "rolloffFactor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConeInnerAngle
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "coneInnerAngle");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "coneInnerAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConeOuterAngle
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "coneOuterAngle");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "coneOuterAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConeOuterGain
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "coneOuterGain");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "coneOuterGain", value);
    }
}

#nullable disable