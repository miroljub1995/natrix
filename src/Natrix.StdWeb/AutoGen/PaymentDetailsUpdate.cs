// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentDetailsUpdate: global::Natrix.StdWeb.PaymentDetailsBase, global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsUpdate>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsUpdate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentDetailsUpdate global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsUpdate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsUpdate(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Error
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "error");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "error", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentItem Total
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Get(JSObject, "total");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Set(JSObject, "total", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AddressErrors ShippingAddressErrors
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressErrors>.Get(JSObject, "shippingAddressErrors");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressErrors>.Set(JSObject, "shippingAddressErrors", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PayerErrors PayerErrors
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PayerErrors>.Get(JSObject, "payerErrors");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PayerErrors>.Set(JSObject, "payerErrors", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject PaymentMethodErrors
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "paymentMethodErrors");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "paymentMethodErrors", value);
    }
}

#nullable disable