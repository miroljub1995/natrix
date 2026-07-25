// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSTransition: global::Natrix.StdWeb.Animation
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSTransition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TransitionProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transitionProperty");
    }
}

#nullable disable