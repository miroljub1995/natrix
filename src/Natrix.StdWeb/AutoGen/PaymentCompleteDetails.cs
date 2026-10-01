// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentCompleteDetails: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentCompleteDetails>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentCompleteDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentCompleteDetails global::Natrix.JSCore.IJSObjectProxy<PaymentCompleteDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentCompleteDetails(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? Data
    {
        get => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Set(JSObject, "data", value);
    }
}

#nullable disable