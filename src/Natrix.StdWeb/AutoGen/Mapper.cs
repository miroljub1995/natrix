// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? MapperManaged(global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? value, ulong index);

public partial class Mapper: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Mapper(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Mapper(MapperManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator Mapper(MapperManaged input)
    {
        return new global::Natrix.StdWeb.Mapper(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.MapperManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.MapperManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (value, index) =>
        {
            int ___argsArrayLength_3 = 2;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
            if (value is null)
            {
                ___propObject_4 = null;
            }
            else
            {
                ___propObject_4 = value.JSObject;
            }

            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

            // Argument 2
            double ___marshalledValue_5;
            ___marshalledValue_5 = Convert.ToDouble(index);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
            ___propObject_6 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(___resOwner_1.JSObject, "value");
            if (___propObject_6 is null)
            {
                ___res_2 = null;
            }
            else
            {
                ___res_2 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_6);
            }
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(MapperManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_7) =>
        {
            using (___args_0)
            using (___res_7)
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

                // Argument 2
                ulong ___arg_4;
                double ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 1);
                ___arg_4 = Convert.ToUInt64(___res_5);

                global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___managedRes_8 = input(___arg_2, ___arg_4);

                global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_9;
                if (___managedRes_8 is null)
                {
                    ___propObject_9 = null;
                }
                else
                {
                    ___propObject_9 = ___managedRes_8.JSObject;
                }

                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___res_7, "value", ___propObject_9);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_6 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_6, input); 

        return ___funcObj_6;
    }
}

#nullable disable