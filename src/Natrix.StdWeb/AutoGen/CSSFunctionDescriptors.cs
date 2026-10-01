// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFunctionDescriptors: global::Natrix.StdWeb.CSSStyleDeclaration, global::Natrix.JSCore.IJSObjectProxy<CSSFunctionDescriptors>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFunctionDescriptors(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFunctionDescriptors global::Natrix.JSCore.IJSObjectProxy<CSSFunctionDescriptors>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFunctionDescriptors>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Result
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "result");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "result", value);
    }
}

#nullable disable