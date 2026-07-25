// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AbsoluteOrientationSensor: global::Natrix.StdWeb.OrientationSensor
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AbsoluteOrientationSensor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AbsoluteOrientationSensor New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AbsoluteOrientationSensor");
        return new global::Natrix.StdWeb.AbsoluteOrientationSensor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AbsoluteOrientationSensor New(global::Natrix.StdWeb.OrientationSensorOptions sensorOptions)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = sensorOptions.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AbsoluteOrientationSensor", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.AbsoluteOrientationSensor(___res_2);
    }
}

#nullable disable