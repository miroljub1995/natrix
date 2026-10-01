// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<USBPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<USBPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>> Filters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>>>(JSObject, "filters");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>>>(JSObject, "filters", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>> ExclusionFilters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>>>(JSObject, "exclusionFilters");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBDeviceFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDeviceFilter>>>>(JSObject, "exclusionFilters", value);
    }
}

#nullable disable