// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GeolocationCoordinates: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GeolocationCoordinates>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GeolocationCoordinates(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GeolocationCoordinates global::Natrix.JSCore.IJSObjectProxy<GeolocationCoordinates>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GeolocationCoordinates>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Accuracy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "accuracy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Latitude
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "latitude");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Longitude
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "longitude");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Altitude
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "altitude");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? AltitudeAccuracy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "altitudeAccuracy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Heading
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "heading");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Speed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "speed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable