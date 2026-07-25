// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? UnderlyingSourceStartCallbackManaged(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStreamDefaultController, global::Natrix.StdWeb.ReadableByteStreamController, global::Natrix.StdWeb.GenericMarshaller.Union> controller);

public partial class UnderlyingSourceStartCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSourceStartCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSourceStartCallback(UnderlyingSourceStartCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator UnderlyingSourceStartCallback(UnderlyingSourceStartCallbackManaged input)
    {
        return new global::Natrix.StdWeb.UnderlyingSourceStartCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.UnderlyingSourceStartCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.UnderlyingSourceStartCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (controller) =>
        {
            int ___argsArrayLength_3 = 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = controller.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_5;
            ___propObject_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(___resOwner_1.JSObject, "value");
            if (___propObject_5 is null)
            {
                ___res_2 = null;
            }
            else
            {
                ___res_2 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_5);
            }
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(UnderlyingSourceStartCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_5) =>
        {
            using (___args_0)
            using (___res_5)
            {
                // Argument 1
                global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStreamDefaultController, global::Natrix.StdWeb.ReadableByteStreamController, global::Natrix.StdWeb.GenericMarshaller.Union> ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3;
                ___propObject_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2(___args_0, 0);
                ___arg_2 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStreamDefaultController, global::Natrix.StdWeb.ReadableByteStreamController, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_3);

                global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___managedRes_6 = input(___arg_2);

                global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_7;
                if (___managedRes_6 is null)
                {
                    ___propObject_7 = null;
                }
                else
                {
                    ___propObject_7 = ___managedRes_6.JSObject;
                }

                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___res_5, "value", ___propObject_7);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_4 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_4, input); 

        return ___funcObj_4;
    }
}

#nullable disable