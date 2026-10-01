// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AttributionAggregationService: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AttributionAggregationService>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionAggregationService(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AttributionAggregationService global::Natrix.JSCore.IJSObjectProxy<AttributionAggregationService>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AttributionAggregationService(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AttributionAggregationProtocol Protocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AttributionAggregationProtocol, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AttributionAggregationProtocol>>(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AttributionAggregationProtocol, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AttributionAggregationProtocol>>(JSObject, "protocol", value);
    }
}

#nullable disable