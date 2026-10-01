// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RegistrationOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RegistrationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RegistrationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RegistrationOptions global::Natrix.JSCore.IJSObjectProxy<RegistrationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RegistrationOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Scope
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "scope");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "scope", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WorkerType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WorkerType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WorkerType>>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WorkerType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WorkerType>>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ServiceWorkerUpdateViaCache UpdateViaCache
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ServiceWorkerUpdateViaCache, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ServiceWorkerUpdateViaCache>>(JSObject, "updateViaCache");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ServiceWorkerUpdateViaCache, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ServiceWorkerUpdateViaCache>>(JSObject, "updateViaCache", value);
    }
}

#nullable disable