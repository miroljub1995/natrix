// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AttributionConversionOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AttributionConversionOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionConversionOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AttributionConversionOptions global::Natrix.JSCore.IJSObjectProxy<AttributionConversionOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionConversionOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string AggregationService
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "aggregationService");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "aggregationService", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Epsilon
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "epsilon");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "epsilon", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint HistogramSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "histogramSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "histogramSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint LookbackDays
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lookbackDays");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lookbackDays", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor> MatchValues
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "matchValues");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Set(JSObject, "matchValues", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ImpressionSites
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "impressionSites");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "impressionSites", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ImpressionCallers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "impressionCallers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "impressionCallers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor> Credit
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "credit");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "credit", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Value
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxValue
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "maxValue");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "maxValue", value);
    }
}

#nullable disable