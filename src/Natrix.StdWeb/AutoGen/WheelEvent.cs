// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WheelEvent: global::Natrix.StdWeb.MouseEvent
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WheelEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WheelEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WheelEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WheelEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WheelEvent New(string type, global::Natrix.StdWeb.WheelEventInit eventInitDict)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WheelEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WheelEvent(___res_2);
    }

    public const uint DOM_DELTA_PIXEL = 0x00;

    public const uint DOM_DELTA_LINE = 0x01;

    public const uint DOM_DELTA_PAGE = 0x02;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "deltaX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "deltaY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DeltaZ
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "deltaZ");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DeltaMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "deltaMode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Momentum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "momentum");
    }
}

#nullable disable