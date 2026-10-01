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
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities>.Get(JSObject, "sourceCapabilities");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities>.Set(JSObject, "sourceCapabilities", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? View
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>.Get(JSObject, "view");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>.Set(JSObject, "view", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Detail
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "detail");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "detail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Which
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "which");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "which", value);
    }
}

#nullable disable