// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UADataValues: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<UADataValues>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UADataValues(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static UADataValues global::Natrix.JSCore.IJSObjectProxy<UADataValues>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UADataValues(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Architecture
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "architecture");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "architecture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Bitness
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "bitness");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "bitness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>> Brands
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Get(JSObject, "brands");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Set(JSObject, "brands", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> FormFactors
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "formFactors");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "formFactors", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>> FullVersionList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Get(JSObject, "fullVersionList");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Set(JSObject, "fullVersionList", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Model
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "model");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "model", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Mobile
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mobile");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "mobile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Platform
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "platform");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "platform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PlatformVersion
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "platformVersion");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "platformVersion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UaFullVersion
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "uaFullVersion");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "uaFullVersion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Wow64
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "wow64");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "wow64", value);
    }
}

#nullable disable