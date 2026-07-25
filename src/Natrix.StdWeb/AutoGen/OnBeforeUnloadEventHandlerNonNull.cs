// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate string? OnBeforeUnloadEventHandlerNonNullManaged(global::Natrix.StdWeb.Event @event);

public partial class OnBeforeUnloadEventHandlerNonNull: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OnBeforeUnloadEventHandlerNonNull(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OnBeforeUnloadEventHandlerNonNull(OnBeforeUnloadEventHandlerNonNullManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator OnBeforeUnloadEventHandlerNonNull(OnBeforeUnloadEventHandlerNonNullManaged input)
    {
        return new global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNullManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNullManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (@event) =>
        {
            int ___argsArrayLength_3 = 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
            ___marshalledValue_4 = @event.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            string? ___res_2;
            string? ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(___resOwner_1.JSObject, "value");
            if (___res_5 is null)
            {
                ___res_2 = null;
            }
            else
            {
                string ___notNullable_6 = (string)___res_5;
                ___res_2 = ___notNullable_6;
            }
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(OnBeforeUnloadEventHandlerNonNullManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_5) =>
        {
            using (___args_0)
            using (___res_5)
            {
                // Argument 1
                global::Natrix.StdWeb.Event ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___args_0, 0);
                ___arg_2 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Event>(___res_3);

                string? ___managedRes_6 = input(___arg_2);

                string? ___marshalledValue_7;
                if (___managedRes_6 is null)
                {
                    ___marshalledValue_7 = null;
                }
                else
                {
                    string ___notNullable_8 = (string)___managedRes_6;
                    ___marshalledValue_7 = ___notNullable_8;
                }
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___res_5, "value", ___marshalledValue_7);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_4 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_4, input); 

        return ___funcObj_4;
    }
}

#nullable disable