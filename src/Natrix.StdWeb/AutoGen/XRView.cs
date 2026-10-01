// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRView: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRView>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRView(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRView global::Natrix.JSCore.IJSObjectProxy<XRView>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRView>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRCamera? Camera
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRCamera>.Get(JSObject, "camera");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsFirstPersonObserver
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isFirstPersonObserver");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XREye Eye
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XREye>.Get(JSObject, "eye");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Index
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "index");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? RecommendedViewportScale
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "recommendedViewportScale");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RequestViewportScale(double? scale)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double? ___marshalledValue_3;
        if (scale is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            double ___notNullable_4 = (double)scale;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "requestViewportScale", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array ProjectionMatrix
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "projectionMatrix");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform Transform
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "transform");
    }
}

#nullable disable