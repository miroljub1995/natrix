// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPassDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPURenderPassDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURenderPassDescriptor global::Natrix.JSCore.IJSObjectProxy<GPURenderPassDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPURenderPassColorAttachment?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment>> ColorAttachments
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPURenderPassColorAttachment?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPURenderPassColorAttachment?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment>>>>(JSObject, "colorAttachments");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPURenderPassColorAttachment?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPURenderPassColorAttachment?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment>>>>(JSObject, "colorAttachments", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPURenderPassDepthStencilAttachment DepthStencilAttachment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPURenderPassDepthStencilAttachment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPURenderPassDepthStencilAttachment>>(JSObject, "depthStencilAttachment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPURenderPassDepthStencilAttachment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPURenderPassDepthStencilAttachment>>(JSObject, "depthStencilAttachment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUQuerySet OcclusionQuerySet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUQuerySet, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQuerySet>>(JSObject, "occlusionQuerySet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUQuerySet, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQuerySet>>(JSObject, "occlusionQuerySet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPURenderPassTimestampWrites TimestampWrites
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPURenderPassTimestampWrites, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPURenderPassTimestampWrites>>(JSObject, "timestampWrites");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPURenderPassTimestampWrites, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPURenderPassTimestampWrites>>(JSObject, "timestampWrites", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxDrawCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxDrawCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxDrawCount", value);
    }
}

#nullable disable