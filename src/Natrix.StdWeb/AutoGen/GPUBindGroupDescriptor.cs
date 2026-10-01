// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBindGroupDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBindGroupDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBindGroupLayout Layout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBindGroupLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout>>(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBindGroupLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout>>(JSObject, "layout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupEntry>> Entries
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupEntry>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupEntry>>>>(JSObject, "entries");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupEntry>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBindGroupEntry>>>>(JSObject, "entries", value);
    }
}

#nullable disable