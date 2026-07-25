// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MouseEventInit: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MouseEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MouseEventInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementX");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementY");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenX");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenY");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientX");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientY");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short Button
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "button");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<short, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "button", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Buttons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buttons");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buttons", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget? RelatedTarget
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventTarget?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "relatedTarget");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventTarget?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "relatedTarget", value);
    }
}

#nullable disable