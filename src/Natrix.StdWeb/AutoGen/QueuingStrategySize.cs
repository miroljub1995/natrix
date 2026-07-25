// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate double QueuingStrategySizeManaged(global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? chunk);

public partial class QueuingStrategySize: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategySize(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategySize(QueuingStrategySizeManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator QueuingStrategySize(QueuingStrategySizeManaged input)
    {
        return new global::Natrix.StdWeb.QueuingStrategySize(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.QueuingStrategySizeManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.QueuingStrategySizeManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (chunk) =>
        {
            int ___argsArrayLength_3 = 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
            if (chunk is null)
            {
                ___propObject_4 = null;
            }
            else
            {
                ___propObject_4 = chunk.JSObject;
            }

            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            double ___res_2;
            double ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___resOwner_1.JSObject, "value");
            ___res_2 = ___res_5;
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(QueuingStrategySizeManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_5) =>
        {
            using (___args_0)
            using (___res_5)
            {
                // Argument 1
                global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
                ___propObject_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(___args_0, 0);
                if (___propObject_3 is null)
                {
                    ___arg_2 = null;
                }
                else
                {
                    ___arg_2 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_3);
                }

                double ___managedRes_6 = input(___arg_2);

                double ___marshalledValue_7;
                ___marshalledValue_7 = ___managedRes_6;
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___res_5, "value", ___marshalledValue_7);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_4 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_4, input); 

        return ___funcObj_4;
    }
}

#nullable disable