// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TrustedTypePolicyOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TrustedTypePolicyOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TrustedTypePolicyOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TrustedTypePolicyOptions global::Natrix.JSCore.IJSObjectProxy<TrustedTypePolicyOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TrustedTypePolicyOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CreateHTMLCallback CreateHTML
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CreateHTMLCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateHTMLCallback>>(JSObject, "createHTML");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CreateHTMLCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateHTMLCallback>>(JSObject, "createHTML", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CreateScriptCallback CreateScript
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CreateScriptCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateScriptCallback>>(JSObject, "createScript");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CreateScriptCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateScriptCallback>>(JSObject, "createScript", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CreateScriptURLCallback CreateScriptURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CreateScriptURLCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateScriptURLCallback>>(JSObject, "createScriptURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CreateScriptURLCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateScriptURLCallback>>(JSObject, "createScriptURL", value);
    }
}

#nullable disable