// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSAnimation: global::Natrix.StdWeb.Animation
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSAnimation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AnimationName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "animationName");
    }
}

#nullable disable