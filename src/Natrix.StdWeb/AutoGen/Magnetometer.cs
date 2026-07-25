// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Magnetometer: global::Natrix.StdWeb.Sensor
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Magnetometer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Magnetometer New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Magnetometer");
        return new global::Natrix.StdWeb.Magnetometer(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Magnetometer New(global::Natrix.StdWeb.MagnetometerSensorOptions sensorOptions)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = sensorOptions.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Magnetometer", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.Magnetometer(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Z
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "z");
    }
}

#nullable disable