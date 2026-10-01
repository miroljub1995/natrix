// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IDBCursorWithValue: global::Natrix.StdWeb.IDBCursor, global::Natrix.JSCore.IJSObjectProxy<IDBCursorWithValue>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBCursorWithValue(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IDBCursorWithValue global::Natrix.JSCore.IJSObjectProxy<IDBCursorWithValue>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IDBCursorWithValue>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Value
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "value");
    }
}

#nullable disable