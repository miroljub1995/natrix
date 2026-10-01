// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentRequestEvent: global::Natrix.StdWeb.ExtendableEvent, global::Natrix.JSCore.IJSObjectProxy<PaymentRequestEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentRequestEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentRequestEvent global::Natrix.JSCore.IJSObjectProxy<PaymentRequestEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PaymentRequestEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.PaymentRequestEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "PaymentRequestEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.PaymentRequestEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.PaymentRequestEvent New(string type, global::Natrix.StdWeb.PaymentRequestEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "PaymentRequestEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.PaymentRequestEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TopOrigin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "topOrigin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PaymentRequestOrigin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "paymentRequestOrigin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PaymentRequestId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "paymentRequestId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>> MethodData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>>>>(JSObject, "methodData");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Total
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(JSObject, "total");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>> Modifiers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>>>(JSObject, "modifiers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? PaymentOptions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject?, global::Natrix.JSCore.Generics.NullableJSObjectAccessor>(JSObject, "paymentOptions");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>? ShippingOptions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>>>(JSObject, "shippingOptions");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WindowClient>> OpenWindow(string url)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "openWindow", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WindowClient>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WindowClient>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>> ChangePaymentMethod(string methodName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = methodName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "changePaymentMethod", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>> ChangePaymentMethod(string methodName, global::System.Runtime.InteropServices.JavaScript.JSObject? methodDetails)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = methodName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_4;
        if (methodDetails is null)
        {
            ___marshalledValue_4 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_5 = (global::System.Runtime.InteropServices.JavaScript.JSObject)methodDetails;
            ___marshalledValue_4 = ___notNullable_5;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "changePaymentMethod", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>> ChangeShippingAddress()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "changeShippingAddress", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>> ChangeShippingAddress(global::Natrix.StdWeb.AddressInit shippingAddress)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = shippingAddress.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "changeShippingAddress", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>> ChangeShippingOption(string shippingOption)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = shippingOption;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "changeShippingOption", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RespondWith(global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PaymentHandlerResponse, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentHandlerResponse>> handlerResponsePromise)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = handlerResponsePromise.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "respondWith", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable