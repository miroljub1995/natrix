// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public delegate void TestCallbackPropertiesVariadicCallbackManaged(long param1, params int[] values);

public partial class TestCallbackPropertiesVariadicCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackPropertiesVariadicCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackPropertiesVariadicCallback(TestCallbackPropertiesVariadicCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator TestCallbackPropertiesVariadicCallback(TestCallbackPropertiesVariadicCallbackManaged input)
    {
        return new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (param1, values) =>
        {
            int ___argsArrayLength_3 = values.Length + 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            double ___marshalledValue_4;
            ___marshalledValue_4 = Convert.ToDouble(param1);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

            // Argument 2
            for (int ___i_5 = 0; ___i_5 < values.Length; ___i_5++)
            {
            int ___elem_6 = values[___i_5];
                double ___marshalledValue_7;
                ___marshalledValue_7 = Convert.ToDouble(___elem_6);
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1 + ___i_5, ___marshalledValue_7);
            }

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunction(JSObject, null, ___argsArray_0.JSObject);
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(TestCallbackPropertiesVariadicCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0) =>
        {
            using (___args_0)
            {
                // Argument 1
                long ___arg_2;
                double ___res_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 0);
                ___arg_2 = Convert.ToInt64(___res_3);

                // Argument 2
                int ___length_1 = global::System.Convert.ToInt32(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, "length"));
                int ___paramsLength_5 = ___length_1 - 1;
                int[] ___arg_4 = new int[___paramsLength_5];
                for (int ___i_6 = 0; ___i_6 < ___paramsLength_5; ___i_6++)
                {
                    int ___paramsItem_7;

                    double ___res_8 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(___args_0, 1 + ___i_6);
                    ___paramsItem_7 = Convert.ToInt32(___res_8);

                    ___arg_4[___i_6] = ___paramsItem_7;
                }

                input(___arg_2, ___arg_4);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_9 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_9, input);

        return ___funcObj_9;
    }
}

#nullable disable