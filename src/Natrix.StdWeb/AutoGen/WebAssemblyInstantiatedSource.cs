// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebAssemblyInstantiatedSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebAssemblyInstantiatedSource>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebAssemblyInstantiatedSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebAssemblyInstantiatedSource global::Natrix.JSCore.IJSObjectProxy<WebAssemblyInstantiatedSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebAssemblyInstantiatedSource(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Module Module
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Module, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Module>>(JSObject, "module");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Module, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Module>>(JSObject, "module", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Instance Instance
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Instance, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Instance>>(JSObject, "instance");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Instance, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Instance>>(JSObject, "instance", value);
    }
}

#nullable disable