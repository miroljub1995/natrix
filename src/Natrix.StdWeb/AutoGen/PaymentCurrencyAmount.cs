// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentCurrencyAmount: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentCurrencyAmount>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentCurrencyAmount(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentCurrencyAmount global::Natrix.JSCore.IJSObjectProxy<PaymentCurrencyAmount>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentCurrencyAmount(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Currency
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "currency");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "currency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }
}

#nullable disable