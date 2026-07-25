// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate void EncodedVideoChunkOutputCallbackManaged(global::Natrix.StdWeb.EncodedVideoChunk chunk, global::Natrix.StdWeb.EncodedVideoChunkMetadata metadata);

public partial class EncodedVideoChunkOutputCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncodedVideoChunkOutputCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncodedVideoChunkOutputCallback(EncodedVideoChunkOutputCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator EncodedVideoChunkOutputCallback(EncodedVideoChunkOutputCallbackManaged input)
    {
        return new global::Natrix.StdWeb.EncodedVideoChunkOutputCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.EncodedVideoChunkOutputCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.EncodedVideoChunkOutputCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (chunk, metadata) =>
        {
            int ___argsArrayLength_3 = 2;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
            ___marshalledValue_4 = chunk.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            // Argument 2
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
            ___marshalledValue_5 = metadata.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunction(JSObject, null, ___argsArray_0.JSObject);
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(EncodedVideoChunkOutputCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0) =>
        {
            using (___args_0)
            {
                // Argument 1
                global::Natrix.StdWeb.EncodedVideoChunk ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___args_0, 0);
                ___arg_2 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.EncodedVideoChunk>(___res_3);

                // Argument 2
                global::Natrix.StdWeb.EncodedVideoChunkMetadata ___arg_4;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___args_0, 1);
                ___arg_4 = new global::Natrix.StdWeb.EncodedVideoChunkMetadata(___res_5);

                input(___arg_2, ___arg_4);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_6 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_6, input);

        return ___funcObj_6;
    }
}

#nullable disable