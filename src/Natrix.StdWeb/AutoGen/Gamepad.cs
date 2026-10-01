// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Gamepad: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Gamepad>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Gamepad(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Gamepad global::Natrix.JSCore.IJSObjectProxy<Gamepad>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Gamepad>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadHand Hand
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GamepadHand>.Get(JSObject, "hand");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>> HapticActuators
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>>>.Get(JSObject, "hapticActuators");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadPose? Pose
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GamepadPose>.Get(JSObject, "pose");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Index
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "index");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Connected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "connected");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Timestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "timestamp");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadMappingType Mapping
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GamepadMappingType>.Get(JSObject, "mapping");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor> Axes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "axes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadButton, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadButton>> Buttons
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadButton, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadButton>>>.Get(JSObject, "buttons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadTouch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadTouch>> Touches
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadTouch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadTouch>>>.Get(JSObject, "touches");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadHapticActuator VibrationActuator
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>.Get(JSObject, "vibrationActuator");
    }
}

#nullable disable