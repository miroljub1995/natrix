// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUQuerySetDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUQuerySetDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUQuerySetDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUQuerySetDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUQuerySetDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUQuerySetDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUQueryType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUQueryType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUQueryType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Count
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "count");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "count", value);
    }
}

#nullable disable