// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentHandlerResponse: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentHandlerResponse>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentHandlerResponse(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentHandlerResponse global::Natrix.JSCore.IJSObjectProxy<PaymentHandlerResponse>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentHandlerResponse(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MethodName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "methodName");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "methodName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Details
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "details");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "details", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "payerName");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "payerName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerEmail
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "payerEmail");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "payerEmail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerPhone
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "payerPhone");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "payerPhone", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AddressInit ShippingAddress
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressInit>.Get(JSObject, "shippingAddress");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AddressInit>.Set(JSObject, "shippingAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ShippingOption
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "shippingOption");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "shippingOption", value);
    }
}

#nullable disable