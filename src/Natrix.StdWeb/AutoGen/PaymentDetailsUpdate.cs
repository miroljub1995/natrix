// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentDetailsUpdate: global::Natrix.StdWeb.PaymentDetailsBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsUpdate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsUpdate(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Error
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "error");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "error", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentItem Total
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PaymentItem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "total");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PaymentItem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "total", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AddressErrors ShippingAddressErrors
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AddressErrors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shippingAddressErrors");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AddressErrors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shippingAddressErrors", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PayerErrors PayerErrors
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PayerErrors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payerErrors");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PayerErrors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payerErrors", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject PaymentMethodErrors
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "paymentMethodErrors");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "paymentMethodErrors", value);
    }
}

#nullable disable