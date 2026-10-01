// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGBoundingBoxOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGBoundingBoxOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGBoundingBoxOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGBoundingBoxOptions global::Natrix.JSCore.IJSObjectProxy<SVGBoundingBoxOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGBoundingBoxOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Fill
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "fill");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "fill", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Stroke
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "stroke");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "stroke", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Markers
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "markers");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "markers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Clipped
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "clipped");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "clipped", value);
    }
}

#nullable disable