// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UALowEntropyJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<UALowEntropyJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UALowEntropyJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static UALowEntropyJSON global::Natrix.JSCore.IJSObjectProxy<UALowEntropyJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UALowEntropyJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>> Brands
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Get(JSObject, "brands");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Set(JSObject, "brands", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Mobile
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mobile");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "mobile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Platform
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "platform");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "platform", value);
    }
}

#nullable disable