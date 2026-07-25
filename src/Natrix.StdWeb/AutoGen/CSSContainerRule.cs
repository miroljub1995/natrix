// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSContainerRule: global::Natrix.StdWeb.CSSConditionRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSContainerRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "containerName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerQuery
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "containerQuery");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSContainerCondition, global::Natrix.StdWeb.PropertyAccessor> Conditions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSContainerCondition, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "conditions");
    }
}

#nullable disable