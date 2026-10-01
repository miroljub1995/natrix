// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PurchaseDetails: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PurchaseDetails>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PurchaseDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PurchaseDetails global::Natrix.JSCore.IJSObjectProxy<PurchaseDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PurchaseDetails(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ItemId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "itemId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "itemId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string PurchaseToken
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "purchaseToken");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "purchaseToken", value);
    }
}

#nullable disable