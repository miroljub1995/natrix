// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GamepadPose: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GamepadPose>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GamepadPose global::Natrix.JSCore.IJSObjectProxy<GamepadPose>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GamepadPose>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasOrientation
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasOrientation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasPosition
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasPosition");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? Position
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "position");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? LinearVelocity
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "linearVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? LinearAcceleration
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "linearAcceleration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? Orientation
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "orientation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? AngularVelocity
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "angularVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array? AngularAcceleration
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "angularAcceleration");
    }
}

#nullable disable