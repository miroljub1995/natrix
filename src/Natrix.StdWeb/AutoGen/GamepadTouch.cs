// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GamepadTouch: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GamepadTouch>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadTouch(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GamepadTouch global::Natrix.JSCore.IJSObjectProxy<GamepadTouch>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadTouch(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TouchId
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "touchId");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "touchId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte SurfaceId
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "surfaceId");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "surfaceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly Position
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "position");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Set(JSObject, "position", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly? SurfaceDimensions
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "surfaceDimensions");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Set(JSObject, "surfaceDimensions", value);
    }
}

#nullable disable