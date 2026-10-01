// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ItemDetails: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ItemDetails>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ItemDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ItemDetails global::Natrix.JSCore.IJSObjectProxy<ItemDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ItemDetails(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ItemId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "itemId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "itemId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Title
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "title");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "title", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PaymentCurrencyAmount Price
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Get(JSObject, "price");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Set(JSObject, "price", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ItemType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ItemType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ItemType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Description
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "description");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "description", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> IconURLs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "iconURLs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "iconURLs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SubscriptionPeriod
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "subscriptionPeriod");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "subscriptionPeriod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FreeTrialPeriod
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "freeTrialPeriod");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "freeTrialPeriod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PaymentCurrencyAmount IntroductoryPrice
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Get(JSObject, "introductoryPrice");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PaymentCurrencyAmount>.Set(JSObject, "introductoryPrice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string IntroductoryPricePeriod
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "introductoryPricePeriod");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "introductoryPricePeriod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong IntroductoryPriceCycles
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "introductoryPriceCycles");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "introductoryPriceCycles", value);
    }
}

#nullable disable