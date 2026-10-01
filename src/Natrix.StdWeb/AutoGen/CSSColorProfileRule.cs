// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSColorProfileRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSColorProfileRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSColorProfileRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSColorProfileRule global::Natrix.JSCore.IJSObjectProxy<CSSColorProfileRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSColorProfileRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RenderingIntent
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "renderingIntent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Components
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "components");
    }
}

#nullable disable