// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PaymentDetailsInit: global::Natrix.StdWeb.PaymentDetailsBase, global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PaymentDetailsInit global::Natrix.JSCore.IJSObjectProxy<PaymentDetailsInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PaymentDetailsInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PaymentItem Total
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Get(JSObject, "total");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentItem>.Set(JSObject, "total", value);
    }
}

#nullable disable