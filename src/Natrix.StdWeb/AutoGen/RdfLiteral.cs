// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RdfLiteral: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RdfLiteral>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RdfLiteral(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RdfLiteral global::Natrix.JSCore.IJSObjectProxy<RdfLiteral>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RdfLiteral>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RdfLiteral New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RdfLiteral");
        return new global::Natrix.StdWeb.RdfLiteral(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Datatype
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "datatype");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Language
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "language");
    }
}

#nullable disable