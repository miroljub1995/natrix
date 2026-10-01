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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GamepadHand, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GamepadHand>>(JSObject, "hand");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>> HapticActuators
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>>>>(JSObject, "hapticActuators");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadPose? Pose
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GamepadPose?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GamepadPose>>(JSObject, "pose");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Index
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "index");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Connected
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "connected");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Timestamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "timestamp");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadMappingType Mapping
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GamepadMappingType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GamepadMappingType>>(JSObject, "mapping");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor> Axes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "axes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadButton, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadButton>> Buttons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadButton, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadButton>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadButton, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadButton>>>>(JSObject, "buttons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadTouch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadTouch>> Touches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadTouch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadTouch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GamepadTouch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadTouch>>>>(JSObject, "touches");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GamepadHapticActuator VibrationActuator
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GamepadHapticActuator, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GamepadHapticActuator>>(JSObject, "vibrationActuator");
    }
}

#nullable disable