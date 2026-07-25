// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate void XRFrameRequestCallbackManaged(double time, global::Natrix.StdWeb.XRFrame frame);

public partial class XRFrameRequestCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRFrameRequestCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRFrameRequestCallback(XRFrameRequestCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator XRFrameRequestCallback(XRFrameRequestCallbackManaged input)
    {
        return new global::Natrix.StdWeb.XRFrameRequestCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.XRFrameRequestCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.XRFrameRequestCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (time, frame) =>
        {
            int ___argsArrayLength_3 = 2;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            double ___marshalledValue_4;
            ___marshalledValue_4 = time;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            // Argument 2
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
            ___marshalledValue_5 = frame.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunction(JSObject, null, ___argsArray_0.JSObject);
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(XRFrameRequestCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0) =>
        {
            using (___args_0)
            {
                // Argument 1
                double ___arg_2;
                double ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 0);
                ___arg_2 = ___res_3;

                // Argument 2
                global::Natrix.StdWeb.XRFrame ___arg_4;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___args_0, 1);
                ___arg_4 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRFrame>(___res_5);

                input(___arg_2, ___arg_4);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_6 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_6, input);

        return ___funcObj_6;
    }
}

#nullable disable