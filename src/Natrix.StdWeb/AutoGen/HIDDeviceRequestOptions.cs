// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDDeviceRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HIDDeviceRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDDeviceRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDDeviceRequestOptions global::Natrix.JSCore.IJSObjectProxy<HIDDeviceRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDDeviceRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>> Filters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>>>(JSObject, "filters");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>>>(JSObject, "filters", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>> ExclusionFilters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>>>(JSObject, "exclusionFilters");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDeviceFilter>>>>(JSObject, "exclusionFilters", value);
    }
}

#nullable disable