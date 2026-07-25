// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Presentation: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Presentation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PresentationRequest? DefaultRequest
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PresentationRequest?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "defaultRequest");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PresentationRequest?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "defaultRequest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PresentationReceiver? Receiver
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PresentationReceiver?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "receiver");
    }
}

#nullable disable