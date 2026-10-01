// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentOptions global::Natrix.JSCore.IJSObjectProxy<PaymentOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestPayerName
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestPayerName");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestPayerName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestBillingAddress
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestBillingAddress");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestBillingAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestPayerEmail
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestPayerEmail");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestPayerEmail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestPayerPhone
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestPayerPhone");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestPayerPhone", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestShipping
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestShipping");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestShipping", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentShippingType ShippingType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PaymentShippingType>.Get(JSObject, "shippingType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PaymentShippingType>.Set(JSObject, "shippingType", value);
    }
}

#nullable disable