// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBufferDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUBufferDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBufferDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUBufferDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ulong Size
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "size", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Usage
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "usage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MappedAtCreation
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mappedAtCreation");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "mappedAtCreation", value);
    }
}

#nullable disable