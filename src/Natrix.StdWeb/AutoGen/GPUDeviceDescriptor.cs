// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUDeviceDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUDeviceDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUDeviceDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUDeviceDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUDeviceDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUDeviceDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUFeatureName, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFeatureName>> RequiredFeatures
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUFeatureName, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFeatureName>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUFeatureName, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFeatureName>>>>(JSObject, "requiredFeatures");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUFeatureName, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFeatureName>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUFeatureName, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFeatureName>>>>(JSObject, "requiredFeatures", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor> RequiredLimits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Record<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>>>(JSObject, "requiredLimits");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Record<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>>>(JSObject, "requiredLimits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUQueueDescriptor DefaultQueue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUQueueDescriptor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQueueDescriptor>>(JSObject, "defaultQueue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUQueueDescriptor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQueueDescriptor>>(JSObject, "defaultQueue", value);
    }
}

#nullable disable