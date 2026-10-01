// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BackgroundFetchUIOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchUIOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchUIOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BackgroundFetchUIOptions global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchUIOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchUIOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ImageResource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageResource>> Icons
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ImageResource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageResource>>>.Get(JSObject, "icons");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ImageResource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageResource>>>.Set(JSObject, "icons", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Title
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "title");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "title", value);
    }
}

#nullable disable