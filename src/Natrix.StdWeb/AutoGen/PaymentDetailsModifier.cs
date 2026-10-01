// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentDetailsModifier: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsModifier>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsModifier(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentDetailsModifier global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsModifier>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsModifier(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string SupportedMethods
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "supportedMethods");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "supportedMethods", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentItem Total
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Get(JSObject, "total");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Set(JSObject, "total", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>> AdditionalDisplayItems
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>>>.Get(JSObject, "additionalDisplayItems");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>>>.Set(JSObject, "additionalDisplayItems", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Data
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "data", value);
    }
}

#nullable disable