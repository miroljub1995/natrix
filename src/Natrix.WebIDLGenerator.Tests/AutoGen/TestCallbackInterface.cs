// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestCallbackInterface: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestCallbackInterface>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackInterface(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestCallbackInterface global::Natrix.JSCore.IJSObjectProxy<TestCallbackInterface>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestCallbackInterface>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InvokeCallback(global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallback callbackInterface)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = callbackInterface.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "invokeCallback", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.StringAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable