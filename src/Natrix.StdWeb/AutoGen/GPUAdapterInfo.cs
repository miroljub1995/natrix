// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUAdapterInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUAdapterInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUAdapterInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUAdapterInfo global::Natrix.JSCore.IJSObjectProxy<GPUAdapterInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUAdapterInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Vendor
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "vendor");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Architecture
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "architecture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Device
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "device");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Description
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "description");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SubgroupMinSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "subgroupMinSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SubgroupMaxSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "subgroupMaxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsFallbackAdapter
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isFallbackAdapter");
    }
}

#nullable disable