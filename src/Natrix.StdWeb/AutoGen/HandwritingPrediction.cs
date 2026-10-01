// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingPrediction: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingPrediction>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingPrediction(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingPrediction global::Natrix.JSCore.IJSObjectProxy<HandwritingPrediction>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingPrediction(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingSegment>> SegmentationResult
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingSegment>>>.Get(JSObject, "segmentationResult");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingSegment>>>.Set(JSObject, "segmentationResult", value);
    }
}

#nullable disable