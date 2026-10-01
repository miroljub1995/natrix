// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MemoryAttribution: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MemoryAttribution>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryAttribution(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MemoryAttribution global::Natrix.JSCore.IJSObjectProxy<MemoryAttribution>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryAttribution(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MemoryAttributionContainer Container
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryAttributionContainer>.Get(JSObject, "container");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryAttributionContainer>.Set(JSObject, "container", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Scope
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scope");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scope", value);
    }
}

#nullable disable