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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUQueryType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUQueryType>>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUQueryType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUQueryType>>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Count
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "count");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "count", value);
    }
}

#nullable disable