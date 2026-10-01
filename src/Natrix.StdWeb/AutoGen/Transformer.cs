// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Transformer: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Transformer>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Transformer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Transformer global::Natrix.JSCore.IJSObjectProxy<Transformer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Transformer(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TransformerStartCallback Start
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerStartCallback>.Get(JSObject, "start");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerStartCallback>.Set(JSObject, "start", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TransformerTransformCallback Transform
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerTransformCallback>.Get(JSObject, "transform");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerTransformCallback>.Set(JSObject, "transform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TransformerFlushCallback Flush
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerFlushCallback>.Get(JSObject, "flush");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerFlushCallback>.Set(JSObject, "flush", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TransformerCancelCallback Cancel
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerCancelCallback>.Get(JSObject, "cancel");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TransformerCancelCallback>.Set(JSObject, "cancel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? ReadableType
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "readableType");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "readableType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? WritableType
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "writableType");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "writableType", value);
    }
}

#nullable disable