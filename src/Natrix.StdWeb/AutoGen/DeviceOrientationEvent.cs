// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceOrientationEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<DeviceOrientationEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceOrientationEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceOrientationEvent global::Natrix.JSCore.IJSObjectProxy<DeviceOrientationEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DeviceOrientationEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.DeviceOrientationEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.DeviceOrientationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.DeviceOrientationEvent New(string type, global::Natrix.StdWeb.DeviceOrientationEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.DeviceOrientationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Alpha
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "alpha");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Beta
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "beta");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Gamma
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "gamma");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Absolute
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "absolute");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PermissionState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>> RequestPermission()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent"), "requestPermission", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent"), ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PermissionState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PermissionState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>> RequestPermission(bool absolute)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        bool ___marshalledValue_3;
        ___marshalledValue_3 = absolute;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent"), "requestPermission", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DeviceOrientationEvent"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PermissionState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable