// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PresentationAvailability: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<PresentationAvailability>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationAvailability(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PresentationAvailability global::Natrix.JSCore.IJSObjectProxy<PresentationAvailability>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PresentationAvailability>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Value
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }
}

#nullable disable