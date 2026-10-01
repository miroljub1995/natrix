// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PreferenceManager: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PreferenceManager>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PreferenceManager(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PreferenceManager global::Natrix.JSCore.IJSObjectProxy<PreferenceManager>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PreferenceManager>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PreferenceObject ColorScheme
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PreferenceObject, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PreferenceObject>>(JSObject, "colorScheme");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PreferenceObject Contrast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PreferenceObject, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PreferenceObject>>(JSObject, "contrast");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PreferenceObject ReducedMotion
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PreferenceObject, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PreferenceObject>>(JSObject, "reducedMotion");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PreferenceObject ReducedTransparency
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PreferenceObject, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PreferenceObject>>(JSObject, "reducedTransparency");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PreferenceObject ReducedData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PreferenceObject, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PreferenceObject>>(JSObject, "reducedData");
    }
}

#nullable disable