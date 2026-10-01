// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Gyroscope: global::Natrix.StdWeb.Sensor, global::Natrix.JSCore.IJSObjectProxy<Gyroscope>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Gyroscope(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Gyroscope global::Natrix.JSCore.IJSObjectProxy<Gyroscope>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Gyroscope>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Gyroscope New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Gyroscope");
        return new global::Natrix.StdWeb.Gyroscope(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Gyroscope New(global::Natrix.StdWeb.GyroscopeSensorOptions sensorOptions)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = sensorOptions.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Gyroscope", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.Gyroscope(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? X
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Y
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Z
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "z");
    }
}

#nullable disable