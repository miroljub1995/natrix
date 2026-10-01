// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RdfTriple: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RdfTriple>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RdfTriple(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RdfTriple global::Natrix.JSCore.IJSObjectProxy<RdfTriple>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RdfTriple>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RdfTriple New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RdfTriple");
        return new global::Natrix.StdWeb.RdfTriple(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Subject
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "subject");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Predicate
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "predicate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.RdfLiteral, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RdfLiteral>> Object
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.RdfLiteral, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RdfLiteral>>>.Get(JSObject, "object");
    }
}

#nullable disable