// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigateEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<NavigateEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigateEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigateEventInit global::Natrix.JSCore.IJSObjectProxy<NavigateEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigateEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationType NavigationType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationType>.Get(JSObject, "navigationType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationType>.Set(JSObject, "navigationType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.NavigationDestination Destination
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationDestination>.Get(JSObject, "destination");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationDestination>.Set(JSObject, "destination", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CanIntercept
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "canIntercept");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "canIntercept", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UserInitiated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "userInitiated");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "userInitiated", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HashChange
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hashChange");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hashChange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FormData? FormData
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FormData>.Get(JSObject, "formData");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FormData>.Set(JSObject, "formData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? DownloadRequest
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "downloadRequest");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "downloadRequest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Info
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "info");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "info", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasUAVisualTransition
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasUAVisualTransition");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hasUAVisualTransition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? SourceElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "sourceElement");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "sourceElement", value);
    }
}

#nullable disable