// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSLayerBlockRule: global::Natrix.StdWeb.CSSGroupingRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSLayerBlockRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }
}

#nullable disable