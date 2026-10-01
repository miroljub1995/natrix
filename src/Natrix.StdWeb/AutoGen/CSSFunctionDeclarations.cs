// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFunctionDeclarations: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSFunctionDeclarations>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFunctionDeclarations(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFunctionDeclarations global::Natrix.JSCore.IJSObjectProxy<CSSFunctionDeclarations>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFunctionDeclarations>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFunctionDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFunctionDescriptors>.Get(JSObject, "style");
    }
}

#nullable disable