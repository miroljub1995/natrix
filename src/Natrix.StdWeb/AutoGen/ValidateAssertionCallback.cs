// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.RTCIdentityValidationResult, global::Natrix.StdWeb.PropertyAccessor> ValidateAssertionCallbackManaged(string assertion, string origin);

public partial class ValidateAssertionCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidateAssertionCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidateAssertionCallback(ValidateAssertionCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator ValidateAssertionCallback(ValidateAssertionCallbackManaged input)
    {
        return new global::Natrix.StdWeb.ValidateAssertionCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.ValidateAssertionCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.ValidateAssertionCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (assertion, origin) =>
        {
            int ___argsArrayLength_3 = 2;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            string ___marshalledValue_4;
            ___marshalledValue_4 = assertion;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            // Argument 2
            string ___marshalledValue_5;
            ___marshalledValue_5 = origin;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.RTCIdentityValidationResult, global::Natrix.StdWeb.PropertyAccessor> ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6;
            ___propObject_6 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___resOwner_1.JSObject, "value");
            ___res_2 = new global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.RTCIdentityValidationResult, global::Natrix.StdWeb.PropertyAccessor>(___propObject_6);
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(ValidateAssertionCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_7) =>
        {
            using (___args_0)
            using (___res_7)
            {
                // Argument 1
                string ___arg_2;
                string ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(___args_0, 0);
                ___arg_2 = ___res_3;

                // Argument 2
                string ___arg_4;
                string ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(___args_0, 1);
                ___arg_4 = ___res_5;

                global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.RTCIdentityValidationResult, global::Natrix.StdWeb.PropertyAccessor> ___managedRes_8 = input(___arg_2, ___arg_4);

                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_9 = ___managedRes_8.JSObject;
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___res_7, "value", ___propObject_9);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_6 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_6, input); 

        return ___funcObj_6;
    }
}

#nullable disable