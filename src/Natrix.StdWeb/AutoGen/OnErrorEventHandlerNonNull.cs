// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? OnErrorEventHandlerNonNullManaged(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Event, string, global::Natrix.StdWeb.GenericMarshaller.Union> @event, string source, uint lineno, uint colno, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? error);

public partial class OnErrorEventHandlerNonNull: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OnErrorEventHandlerNonNull(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OnErrorEventHandlerNonNull(OnErrorEventHandlerNonNullManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator OnErrorEventHandlerNonNull(OnErrorEventHandlerNonNullManaged input)
    {
        return new global::Natrix.StdWeb.OnErrorEventHandlerNonNull(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.OnErrorEventHandlerNonNullManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.OnErrorEventHandlerNonNullManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (@event, source, lineno, colno, error) =>
        {
            int ___argsArrayLength_3 = 5;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = @event.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

            // Argument 2
            string ___marshalledValue_5;
            ___marshalledValue_5 = source;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            // Argument 3
            double ___marshalledValue_6;
            ___marshalledValue_6 = Convert.ToDouble(lineno);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_6);

            // Argument 4
            double ___marshalledValue_7;
            ___marshalledValue_7 = Convert.ToDouble(colno);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 3, ___marshalledValue_7);

            // Argument 5
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_8;
            if (error is null)
            {
                ___propObject_8 = null;
            }
            else
            {
                ___propObject_8 = error.JSObject;
            }

            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 4, ___propObject_8);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_9;
            ___propObject_9 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(___resOwner_1.JSObject, "value");
            if (___propObject_9 is null)
            {
                ___res_2 = null;
            }
            else
            {
                ___res_2 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_9);
            }
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(OnErrorEventHandlerNonNullManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_13) =>
        {
            using (___args_0)
            using (___res_13)
            {
                // Argument 1
                global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Event, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3;
                ___propObject_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2(___args_0, 0);
                ___arg_2 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Event, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_3);

                // Argument 2
                string ___arg_4;
                string ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(___args_0, 1);
                ___arg_4 = ___res_5;

                // Argument 3
                uint ___arg_6;
                double ___res_7 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 2);
                ___arg_6 = Convert.ToUInt32(___res_7);

                // Argument 4
                uint ___arg_8;
                double ___res_9 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 3);
                ___arg_8 = Convert.ToUInt32(___res_9);

                // Argument 5
                global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___arg_10;
                global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_11;
                ___propObject_11 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(___args_0, 4);
                if (___propObject_11 is null)
                {
                    ___arg_10 = null;
                }
                else
                {
                    ___arg_10 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_11);
                }

                global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? ___managedRes_14 = input(___arg_2, ___arg_4, ___arg_6, ___arg_8, ___arg_10);

                global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_15;
                if (___managedRes_14 is null)
                {
                    ___propObject_15 = null;
                }
                else
                {
                    ___propObject_15 = ___managedRes_14.JSObject;
                }

                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___res_13, "value", ___propObject_15);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_12 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_12, input); 

        return ___funcObj_12;
    }
}

#nullable disable