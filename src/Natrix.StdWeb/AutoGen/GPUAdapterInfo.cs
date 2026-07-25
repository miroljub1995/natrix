// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUAdapterInfo: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUAdapterInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Vendor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vendor");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Architecture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "architecture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Device
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "device");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Description
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "description");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SubgroupMinSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "subgroupMinSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SubgroupMaxSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "subgroupMaxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsFallbackAdapter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isFallbackAdapter");
    }
}

#nullable disable