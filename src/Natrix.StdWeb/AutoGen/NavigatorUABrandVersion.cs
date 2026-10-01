// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigatorUABrandVersion: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NavigatorUABrandVersion>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigatorUABrandVersion(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigatorUABrandVersion global::Natrix.JSCore.IJSObjectProxy<NavigatorUABrandVersion>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigatorUABrandVersion(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Brand
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "brand");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "brand", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Version
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "version");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "version", value);
    }
}

#nullable disable