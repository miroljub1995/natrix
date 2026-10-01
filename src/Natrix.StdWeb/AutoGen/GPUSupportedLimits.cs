// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUSupportedLimits: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUSupportedLimits>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUSupportedLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUSupportedLimits global::Natrix.JSCore.IJSObjectProxy<GPUSupportedLimits>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUSupportedLimits>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTextureDimension1D
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxTextureDimension1D");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTextureDimension2D
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxTextureDimension2D");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTextureDimension3D
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxTextureDimension3D");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTextureArrayLayers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxTextureArrayLayers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxBindGroups
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxBindGroups");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxBindGroupsPlusVertexBuffers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxBindGroupsPlusVertexBuffers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxImmediateSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxImmediateSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxBindingsPerBindGroup
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxBindingsPerBindGroup");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxDynamicUniformBuffersPerPipelineLayout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxDynamicUniformBuffersPerPipelineLayout");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxDynamicStorageBuffersPerPipelineLayout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxDynamicStorageBuffersPerPipelineLayout");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxSampledTexturesPerShaderStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxSampledTexturesPerShaderStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxSamplersPerShaderStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxSamplersPerShaderStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageBuffersPerShaderStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageBuffersPerShaderStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageBuffersInVertexStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageBuffersInVertexStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageBuffersInFragmentStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageBuffersInFragmentStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageTexturesPerShaderStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageTexturesPerShaderStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageTexturesInVertexStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageTexturesInVertexStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxStorageTexturesInFragmentStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxStorageTexturesInFragmentStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxUniformBuffersPerShaderStage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxUniformBuffersPerShaderStage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxUniformBufferBindingSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxUniformBufferBindingSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxStorageBufferBindingSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxStorageBufferBindingSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MinUniformBufferOffsetAlignment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "minUniformBufferOffsetAlignment");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MinStorageBufferOffsetAlignment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "minStorageBufferOffsetAlignment");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxVertexBuffers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxVertexBuffers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxBufferSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxBufferSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxVertexAttributes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxVertexAttributes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxVertexBufferArrayStride
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxVertexBufferArrayStride");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxInterStageShaderVariables
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxInterStageShaderVariables");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxColorAttachments
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxColorAttachments");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxColorAttachmentBytesPerSample
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxColorAttachmentBytesPerSample");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeWorkgroupStorageSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeWorkgroupStorageSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeInvocationsPerWorkgroup
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeInvocationsPerWorkgroup");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeWorkgroupSizeX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeWorkgroupSizeX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeWorkgroupSizeY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeWorkgroupSizeY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeWorkgroupSizeZ
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeWorkgroupSizeZ");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxComputeWorkgroupsPerDimension
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxComputeWorkgroupsPerDimension");
    }
}

#nullable disable