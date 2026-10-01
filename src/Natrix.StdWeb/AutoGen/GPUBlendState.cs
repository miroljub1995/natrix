// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBlendState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBlendState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBlendState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBlendState global::Natrix.JSCore.IJSObjectProxy<GPUBlendState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBlendState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBlendComponent Color
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBlendComponent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendComponent>>(JSObject, "color");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBlendComponent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendComponent>>(JSObject, "color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBlendComponent Alpha
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBlendComponent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendComponent>>(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBlendComponent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendComponent>>(JSObject, "alpha", value);
    }
}

#nullable disable