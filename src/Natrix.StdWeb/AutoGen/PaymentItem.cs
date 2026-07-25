// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentItem: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentItem(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentItem(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Label
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "label");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "label", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PaymentCurrencyAmount Amount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PaymentCurrencyAmount, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "amount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PaymentCurrencyAmount, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "amount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Pending
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pending");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pending", value);
    }
}

#nullable disable