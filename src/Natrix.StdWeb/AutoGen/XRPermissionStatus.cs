// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRPermissionStatus: global::Natrix.StdWeb.PermissionStatus
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRPermissionStatus(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor> Granted
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "granted");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "granted", value);
    }
}

#nullable disable