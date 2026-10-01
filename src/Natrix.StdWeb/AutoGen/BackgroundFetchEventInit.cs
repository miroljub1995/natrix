// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BackgroundFetchEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BackgroundFetchEventInit global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.BackgroundFetchRegistration Registration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BackgroundFetchRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration>>(JSObject, "registration");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BackgroundFetchRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration>>(JSObject, "registration", value);
    }
}

#nullable disable