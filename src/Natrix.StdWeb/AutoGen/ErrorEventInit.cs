// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ErrorEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<ErrorEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ErrorEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ErrorEventInit global::Natrix.JSCore.IJSObjectProxy<ErrorEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ErrorEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "message", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Filename
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "filename");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "filename", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Lineno
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lineno");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lineno", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Colno
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "colno");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "colno", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Error
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "error");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "error", value);
    }
}

#nullable disable