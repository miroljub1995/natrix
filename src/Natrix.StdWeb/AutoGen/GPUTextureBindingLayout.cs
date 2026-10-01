// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTextureBindingLayout: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUTextureBindingLayout>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureBindingLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUTextureBindingLayout global::Natrix.JSCore.IJSObjectProxy<GPUTextureBindingLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureBindingLayout(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureSampleType SampleType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureSampleType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureSampleType>>(JSObject, "sampleType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureSampleType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureSampleType>>(JSObject, "sampleType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDimension ViewDimension
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureViewDimension, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>>(JSObject, "viewDimension");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureViewDimension, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>>(JSObject, "viewDimension", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Multisampled
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "multisampled");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "multisampled", value);
    }
}

#nullable disable