// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DOMRectInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DOMRectInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DOMRectInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DOMRectInit global::Natrix.JSCore.IJSObjectProxy<DOMRectInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DOMRectInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double X
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Y
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Height
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "height", value);
    }
}

#nullable disable