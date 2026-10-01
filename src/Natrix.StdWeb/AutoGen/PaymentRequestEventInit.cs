// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentRequestEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<PaymentRequestEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentRequestEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentRequestEventInit global::Natrix.JSCore.IJSObjectProxy<PaymentRequestEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentRequestEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TopOrigin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "topOrigin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "topOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PaymentRequestOrigin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "paymentRequestOrigin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "paymentRequestOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PaymentRequestId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "paymentRequestId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "paymentRequestId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>> MethodData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>>>.Get(JSObject, "methodData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentMethodData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentMethodData>>>.Set(JSObject, "methodData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentCurrencyAmount Total
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Get(JSObject, "total");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Set(JSObject, "total", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>> Modifiers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>>.Get(JSObject, "modifiers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>>.Set(JSObject, "modifiers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentOptions PaymentOptions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentOptions>.Get(JSObject, "paymentOptions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentOptions>.Set(JSObject, "paymentOptions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>> ShippingOptions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>>.Get(JSObject, "shippingOptions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>>.Set(JSObject, "shippingOptions", value);
    }
}

#nullable disable