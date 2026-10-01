// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WheelEventInit: global::Natrix.StdWeb.MouseEventInit, global::Natrix.JSCore.IJSObjectProxy<WheelEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WheelEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WheelEventInit global::Natrix.JSCore.IJSObjectProxy<WheelEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WheelEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "deltaX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "deltaX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "deltaY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "deltaY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaZ
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "deltaZ");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "deltaZ", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DeltaMode
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "deltaMode");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "deltaMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Momentum
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "momentum");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "momentum", value);
    }
}

#nullable disable