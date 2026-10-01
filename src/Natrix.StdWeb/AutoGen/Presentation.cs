// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Presentation: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Presentation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Presentation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Presentation global::Natrix.JSCore.IJSObjectProxy<Presentation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Presentation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PresentationRequest? DefaultRequest
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PresentationRequest?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PresentationRequest>>(JSObject, "defaultRequest");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PresentationRequest?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PresentationRequest>>(JSObject, "defaultRequest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PresentationReceiver? Receiver
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PresentationReceiver?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.PresentationReceiver>>(JSObject, "receiver");
    }
}

#nullable disable