// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentMethodData: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PaymentMethodData>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentMethodData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentMethodData global::Natrix.JSCore.IJSObjectProxy<PaymentMethodData>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentMethodData(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string SupportedMethods
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "supportedMethods");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "supportedMethods", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Data
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "data", value);
    }
}

#nullable disable