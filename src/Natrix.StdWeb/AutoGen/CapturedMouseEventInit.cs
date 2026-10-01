// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CapturedMouseEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<CapturedMouseEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CapturedMouseEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CapturedMouseEventInit global::Natrix.JSCore.IJSObjectProxy<CapturedMouseEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CapturedMouseEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SurfaceX
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "surfaceX");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "surfaceX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SurfaceY
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "surfaceY");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "surfaceY", value);
    }
}

#nullable disable