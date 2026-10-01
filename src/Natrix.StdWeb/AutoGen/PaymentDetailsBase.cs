// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentDetailsBase: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsBase>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsBase(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentDetailsBase global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsBase>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsBase(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>> DisplayItems
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>>>.Get(JSObject, "displayItems");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>>>.Set(JSObject, "displayItems", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>> ShippingOptions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>>.Get(JSObject, "shippingOptions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentShippingOption>>>.Set(JSObject, "shippingOptions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>> Modifiers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>>.Get(JSObject, "modifiers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentDetailsModifier, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentDetailsModifier>>>.Set(JSObject, "modifiers", value);
    }
}

#nullable disable