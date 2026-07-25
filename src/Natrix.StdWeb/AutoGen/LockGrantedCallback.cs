// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> LockGrantedCallbackManaged(global::Natrix.StdWeb.Lock? @lock);

public partial class LockGrantedCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockGrantedCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockGrantedCallback(LockGrantedCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator LockGrantedCallback(LockGrantedCallbackManaged input)
    {
        return new global::Natrix.StdWeb.LockGrantedCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.LockGrantedCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.LockGrantedCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (@lock) =>
        {
            int ___argsArrayLength_3 = 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_4;
            if (@lock is null)
            {
                ___marshalledValue_4 = null;
            }
            else
            {
                global::Natrix.StdWeb.Lock ___notNullable_5 = (global::Natrix.StdWeb.Lock)@lock;
                ___marshalledValue_4 = ___notNullable_5.JSObject;
            }
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6;
            ___propObject_6 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___resOwner_1.JSObject, "value");
            ___res_2 = new global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(___propObject_6);
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(LockGrantedCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_6) =>
        {
            using (___args_0)
            using (___res_6)
            {
                // Argument 1
                global::Natrix.StdWeb.Lock? ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(___args_0, 0);
                if (___res_3 is null)
                {
                    ___arg_2 = null;
                }
                else
                {
                    global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_4 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_3;
                    ___arg_2 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Lock>(___notNullable_4);
                }

                global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> ___managedRes_7 = input(___arg_2);

                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_8 = ___managedRes_7.JSObject;
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___res_6, "value", ___propObject_8);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_5 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_5, input); 

        return ___funcObj_5;
    }
}

#nullable disable