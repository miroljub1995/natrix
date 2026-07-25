// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothCharacteristicProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothCharacteristicProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Broadcast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "broadcast");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Read
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "read");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WriteWithoutResponse
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "writeWithoutResponse");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Write
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "write");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Notify
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "notify");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Indicate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "indicate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AuthenticatedSignedWrites
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "authenticatedSignedWrites");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReliableWrite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reliableWrite");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WritableAuxiliaries
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "writableAuxiliaries");
    }
}

#nullable disable