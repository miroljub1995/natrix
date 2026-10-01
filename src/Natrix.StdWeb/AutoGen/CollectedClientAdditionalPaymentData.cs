// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CollectedClientAdditionalPaymentData: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CollectedClientAdditionalPaymentData>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientAdditionalPaymentData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CollectedClientAdditionalPaymentData global::Natrix.JSCore.IJSObjectProxy<CollectedClientAdditionalPaymentData>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientAdditionalPaymentData(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string RpId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "rpId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "rpId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TopOrigin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "topOrigin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "topOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PayeeName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "payeeName");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "payeeName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PayeeOrigin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "payeeOrigin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "payeeOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentEntityLogo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentEntityLogo>> PaymentEntitiesLogos
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentEntityLogo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentEntityLogo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentEntityLogo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentEntityLogo>>>>(JSObject, "paymentEntitiesLogos");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentEntityLogo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentEntityLogo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PaymentEntityLogo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentEntityLogo>>>>(JSObject, "paymentEntitiesLogos", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PaymentCurrencyAmount Total
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PaymentCurrencyAmount, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>>(JSObject, "total");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PaymentCurrencyAmount, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>>(JSObject, "total", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PaymentCredentialInstrument Instrument
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PaymentCredentialInstrument, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCredentialInstrument>>(JSObject, "instrument");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PaymentCredentialInstrument, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCredentialInstrument>>(JSObject, "instrument", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BrowserBoundPublicKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "browserBoundPublicKey");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "browserBoundPublicKey", value);
    }
}

#nullable disable