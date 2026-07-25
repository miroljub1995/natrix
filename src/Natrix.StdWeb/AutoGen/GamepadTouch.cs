// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GamepadTouch: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadTouch(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadTouch(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TouchId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "touchId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "touchId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte SurfaceId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "surfaceId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "surfaceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly Position
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "position");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "position", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly? SurfaceDimensions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRectReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "surfaceDimensions");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DOMRectReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "surfaceDimensions", value);
    }
}

#nullable disable