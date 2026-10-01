// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentValidationErrors: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentValidationErrors>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentValidationErrors(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentValidationErrors global::Natrix.JSCore.IJSObjectProxy<PaymentValidationErrors>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentValidationErrors(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PayerErrors Payer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PayerErrors>.Get(JSObject, "payer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PayerErrors>.Set(JSObject, "payer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AddressErrors ShippingAddress
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressErrors>.Get(JSObject, "shippingAddress");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressErrors>.Set(JSObject, "shippingAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Error
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "error");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "error", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject PaymentMethod
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "paymentMethod");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "paymentMethod", value);
    }
}

#nullable disable