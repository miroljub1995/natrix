// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SharedWorkerOptions: global::Natrix.StdWeb.WorkerOptions, global::Natrix.JSCore.IJSObjectProxy<SharedWorkerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SharedWorkerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SharedWorkerOptions global::Natrix.JSCore.IJSObjectProxy<SharedWorkerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SharedWorkerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ExtendedLifetime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "extendedLifetime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "extendedLifetime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SameSiteCookiesType SameSiteCookies
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SameSiteCookiesType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SameSiteCookiesType>>(JSObject, "sameSiteCookies");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SameSiteCookiesType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SameSiteCookiesType>>(JSObject, "sameSiteCookies", value);
    }
}

#nullable disable