// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPropertyRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPropertyRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Syntax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "syntax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Inherits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inherits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? InitialValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "initialValue");
    }
}

#nullable disable