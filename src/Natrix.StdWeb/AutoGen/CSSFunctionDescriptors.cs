// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFunctionDescriptors: global::Natrix.StdWeb.CSSStyleDeclaration
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFunctionDescriptors(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Result
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "result");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "result", value);
    }
}

#nullable disable