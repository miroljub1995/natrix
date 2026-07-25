// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentHandlerResponse: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentHandlerResponse(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentHandlerResponse(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MethodName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "methodName");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "methodName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Details
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "details");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "details", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerName");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerEmail
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerEmail");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerEmail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PayerPhone
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerPhone");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "payerPhone", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AddressInit ShippingAddress
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AddressInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shippingAddress");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AddressInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shippingAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ShippingOption
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "shippingOption");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "shippingOption", value);
    }
}

#nullable disable