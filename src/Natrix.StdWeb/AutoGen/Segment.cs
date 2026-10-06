// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Segment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Segment>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Segment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Segment global::Natrix.JSCore.IJSObjectProxy<Segment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Segment(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.SegmentType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SegmentType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SegmentType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required int Id
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PartOf
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "partOf");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "partOf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required float Probability
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "probability");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "probability", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Point2D CenterPoint
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>.Get(JSObject, "centerPoint");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>.Set(JSObject, "centerPoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectInit BoundingBox
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Get(JSObject, "boundingBox");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Set(JSObject, "boundingBox", value);
    }
}

#nullable disable