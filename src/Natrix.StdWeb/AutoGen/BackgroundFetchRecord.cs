// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BackgroundFetchRecord: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchRecord(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Request Request
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Request, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "request");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Response, global::Natrix.StdWeb.PropertyAccessor> ResponseReady
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Response, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseReady");
    }
}

#nullable disable