// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OrientationSensor: global::Natrix.StdWeb.Sensor, global::Natrix.JSCore.IJSObjectProxy<OrientationSensor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OrientationSensor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OrientationSensor global::Natrix.JSCore.IJSObjectProxy<OrientationSensor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<OrientationSensor>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>? Quaternion
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "quaternion");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void PopulateMatrix(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.StdWeb.DOMMatrix, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrix>> targetMatrix)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = targetMatrix.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "populateMatrix", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable