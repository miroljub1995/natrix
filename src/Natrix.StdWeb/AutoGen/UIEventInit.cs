// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UIEventInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<UIEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UIEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static UIEventInit global::Natrix.JSCore.IJSObjectProxy<UIEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UIEventInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.InputDeviceCapabilities? SourceCapabilities
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.InputDeviceCapabilities?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities>>(JSObject, "sourceCapabilities");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.InputDeviceCapabilities?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities>>(JSObject, "sourceCapabilities", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? View
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Window?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>>(JSObject, "view");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Window?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>>(JSObject, "view", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Detail
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "detail");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "detail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Which
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "which");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "which", value);
    }
}

#nullable disable