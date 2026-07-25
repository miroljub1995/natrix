// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSNamespaceRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNamespaceRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NamespaceURI
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "namespaceURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Prefix
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prefix");
    }
}

#nullable disable