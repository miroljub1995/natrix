// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IDBRequest: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<IDBRequest>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBRequest(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IDBRequest global::Natrix.JSCore.IJSObjectProxy<IDBRequest>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IDBRequest>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Result
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "result");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMException? Error
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMException>.Get(JSObject, "error");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBObjectStore>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBIndex>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBCursor>>? Source
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBObjectStore>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBIndex>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IDBCursor>>>.Get(JSObject, "source");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IDBTransaction? Transaction
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.IDBTransaction>.Get(JSObject, "transaction");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IDBRequestReadyState ReadyState
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IDBRequestReadyState>.Get(JSObject, "readyState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onsuccess
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onsuccess");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onsuccess", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onerror", value);
    }
}

#nullable disable