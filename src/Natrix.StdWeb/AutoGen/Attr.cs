// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Attr: global::Natrix.StdWeb.Node, global::Natrix.JSCore.IJSObjectProxy<Attr>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Attr(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Attr global::Natrix.JSCore.IJSObjectProxy<Attr>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Attr>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? NamespaceURI
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "namespaceURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Prefix
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "prefix");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LocalName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "localName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? OwnerElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "ownerElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Specified
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "specified");
    }
}

#nullable disable