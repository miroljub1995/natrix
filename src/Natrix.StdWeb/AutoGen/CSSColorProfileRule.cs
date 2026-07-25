// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSColorProfileRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSColorProfileRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "src");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RenderingIntent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "renderingIntent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Components
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "components");
    }
}

#nullable disable