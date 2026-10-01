// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothCharacteristicProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BluetoothCharacteristicProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothCharacteristicProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothCharacteristicProperties global::Natrix.JSCore.IJSObjectProxy<BluetoothCharacteristicProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothCharacteristicProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Broadcast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "broadcast");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Read
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "read");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WriteWithoutResponse
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "writeWithoutResponse");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Write
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "write");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Notify
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "notify");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Indicate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "indicate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AuthenticatedSignedWrites
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "authenticatedSignedWrites");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReliableWrite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "reliableWrite");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WritableAuxiliaries
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "writableAuxiliaries");
    }
}

#nullable disable