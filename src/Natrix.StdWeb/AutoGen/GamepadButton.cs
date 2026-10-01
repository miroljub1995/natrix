// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GamepadButton: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GamepadButton>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadButton(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GamepadButton global::Natrix.JSCore.IJSObjectProxy<GamepadButton>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GamepadButton>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Pressed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "pressed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Touched
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "touched");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "value");
    }
}

#nullable disable