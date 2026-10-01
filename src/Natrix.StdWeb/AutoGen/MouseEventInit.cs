// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MouseEventInit: global::Natrix.StdWeb.EventModifierInit, global::Natrix.JSCore.IJSObjectProxy<MouseEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MouseEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MouseEventInit global::Natrix.JSCore.IJSObjectProxy<MouseEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MouseEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenX
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "screenX");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "screenX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenY
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "screenY");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "screenY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientX
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientX");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "clientX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientY
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientY");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "clientY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short Button
    {
        get => global::Natrix.JSCore.Generics.Int16Accessor.Get(JSObject, "button");
        set => global::Natrix.JSCore.Generics.Int16Accessor.Set(JSObject, "button", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Buttons
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "buttons");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "buttons", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget? RelatedTarget
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventTarget>.Get(JSObject, "relatedTarget");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventTarget>.Set(JSObject, "relatedTarget", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "movementX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "movementX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "movementY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "movementY", value);
    }
}

#nullable disable