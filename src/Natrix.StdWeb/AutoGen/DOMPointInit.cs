// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DOMPointInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DOMPointInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DOMPointInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DOMPointInit global::Natrix.JSCore.IJSObjectProxy<DOMPointInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DOMPointInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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
    public double Z
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "z");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "z", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double W
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "w");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "w", value);
    }
}

#nullable disable