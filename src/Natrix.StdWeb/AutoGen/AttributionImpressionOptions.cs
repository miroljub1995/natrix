// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AttributionImpressionOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AttributionImpressionOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionImpressionOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AttributionImpressionOptions global::Natrix.JSCore.IJSObjectProxy<AttributionImpressionOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionImpressionOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint HistogramIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "histogramIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "histogramIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MatchValue
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "matchValue");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "matchValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ConversionSites
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "conversionSites");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "conversionSites", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ConversionCallers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "conversionCallers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "conversionCallers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint LifetimeDays
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lifetimeDays");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lifetimeDays", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Priority
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "priority", value);
    }
}

#nullable disable