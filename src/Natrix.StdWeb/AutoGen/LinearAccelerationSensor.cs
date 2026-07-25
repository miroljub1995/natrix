// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LinearAccelerationSensor: global::Natrix.StdWeb.Accelerometer
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LinearAccelerationSensor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.LinearAccelerationSensor New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "LinearAccelerationSensor");
        return new global::Natrix.StdWeb.LinearAccelerationSensor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.LinearAccelerationSensor New(global::Natrix.StdWeb.AccelerometerSensorOptions options)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "LinearAccelerationSensor", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.LinearAccelerationSensor(___res_2);
    }
}

#nullable disable