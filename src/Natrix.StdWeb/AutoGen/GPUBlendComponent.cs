// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBlendComponent: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBlendComponent>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBlendComponent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBlendComponent global::Natrix.JSCore.IJSObjectProxy<GPUBlendComponent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBlendComponent(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBlendOperation Operation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBlendOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendOperation>>(JSObject, "operation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBlendOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendOperation>>(JSObject, "operation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBlendFactor SrcFactor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBlendFactor, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendFactor>>(JSObject, "srcFactor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBlendFactor, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendFactor>>(JSObject, "srcFactor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBlendFactor DstFactor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBlendFactor, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendFactor>>(JSObject, "dstFactor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBlendFactor, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBlendFactor>>(JSObject, "dstFactor", value);
    }
}

#nullable disable