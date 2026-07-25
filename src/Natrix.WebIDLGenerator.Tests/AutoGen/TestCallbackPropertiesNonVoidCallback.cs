// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public delegate int TestCallbackPropertiesNonVoidCallbackManaged(int a, int b);

public partial class TestCallbackPropertiesNonVoidCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackPropertiesNonVoidCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackPropertiesNonVoidCallback(TestCallbackPropertiesNonVoidCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator TestCallbackPropertiesNonVoidCallback(TestCallbackPropertiesNonVoidCallbackManaged input)
    {
        return new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (a, b) =>
        {
            int ___argsArrayLength_3 = 2;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            double ___marshalledValue_4;
            ___marshalledValue_4 = Convert.ToDouble(a);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            // Argument 2
            double ___marshalledValue_5;
            ___marshalledValue_5 = Convert.ToDouble(b);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunction(JSObject, null, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

            // Return Value
            int ___res_2;
            double ___res_6 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___resOwner_1.JSObject, "value");
            ___res_2 = Convert.ToInt32(___res_6);
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(TestCallbackPropertiesNonVoidCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_7) =>
        {
            using (___args_0)
            using (___res_7)
            {
                // Argument 1
                int ___arg_2;
                double ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 0);
                ___arg_2 = Convert.ToInt32(___res_3);

                // Argument 2
                int ___arg_4;
                double ___res_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 1);
                ___arg_4 = Convert.ToInt32(___res_5);

                int ___managedRes_8 = input(___arg_2, ___arg_4);

                double ___marshalledValue_9;
                ___marshalledValue_9 = Convert.ToDouble(___managedRes_8);
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___res_7, "value", ___marshalledValue_9);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_6 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_6, input); 

        return ___funcObj_6;
    }
}

#nullable disable