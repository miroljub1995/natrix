// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XPathNSResolver: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XPathNSResolver>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XPathNSResolver(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XPathNSResolver global::Natrix.JSCore.IJSObjectProxy<XPathNSResolver>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XPathNSResolver>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XPathNSResolver(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XPathNSResolver(global::Natrix.StdWeb.XPathNSResolverCallback input): this()
    {
        LookupNamespaceURI = input;
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XPathNSResolver(global::Natrix.StdWeb.XPathNSResolverCallbackManaged input): this()
    {
        LookupNamespaceURI = input;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator XPathNSResolver(XPathNSResolverCallback input)
    {
        return new global::Natrix.StdWeb.XPathNSResolver(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator XPathNSResolver(XPathNSResolverCallbackManaged input)
    {
        return new global::Natrix.StdWeb.XPathNSResolver(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XPathNSResolverCallback LookupNamespaceURI
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XPathNSResolverCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XPathNSResolverCallback>>(JSObject, "lookupNamespaceURI");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XPathNSResolverCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XPathNSResolverCallback>>(JSObject, "lookupNamespaceURI", value);
    }
}

#nullable disable