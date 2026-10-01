// Accessors for the WebIDL primitive types. Every accessor is its own class, so the trimmer
// keeps only the ones a program actually uses.

using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class BooleanAccessor : IUnionMemberAccessor<bool>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Boolean;

    [SupportedOSPlatform("browser")]
    public static bool Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBooleanV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static bool Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBooleanV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, bool value) =>
        obj.SetPropertyAsBooleanV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, bool value) =>
        obj.SetPropertyAsBooleanV2(propertyIndex, value);
}

public sealed class NullableBooleanAccessor : IPropertyAccessor<bool?>
{
    [SupportedOSPlatform("browser")]
    public static bool? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBooleanV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static bool? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBooleanV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, bool? value) =>
        obj.SetPropertyAsBooleanV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, bool? value) =>
        obj.SetPropertyAsBooleanV2AsNullable(propertyIndex, value);
}

public sealed class ByteAccessor : IUnionMemberAccessor<byte>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static byte Get(JSObject obj, string propertyName) =>
        Convert.ToByte(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static byte Get(JSObject obj, int propertyIndex) =>
        Convert.ToByte(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, byte value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, byte value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableByteAccessor : IPropertyAccessor<byte?>
{
    [SupportedOSPlatform("browser")]
    public static byte? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static byte? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, byte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, byte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class SByteAccessor : IUnionMemberAccessor<sbyte>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static sbyte Get(JSObject obj, string propertyName) =>
        Convert.ToSByte(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static sbyte Get(JSObject obj, int propertyIndex) =>
        Convert.ToSByte(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, sbyte value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, sbyte value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableSByteAccessor : IPropertyAccessor<sbyte?>
{
    [SupportedOSPlatform("browser")]
    public static sbyte? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToSByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static sbyte? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToSByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, sbyte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, sbyte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class Int16Accessor : IUnionMemberAccessor<short>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static short Get(JSObject obj, string propertyName) =>
        Convert.ToInt16(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static short Get(JSObject obj, int propertyIndex) =>
        Convert.ToInt16(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, short value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, short value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableInt16Accessor : IPropertyAccessor<short?>
{
    [SupportedOSPlatform("browser")]
    public static short? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static short? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, short? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, short? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class UInt16Accessor : IUnionMemberAccessor<ushort>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static ushort Get(JSObject obj, string propertyName) =>
        Convert.ToUInt16(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static ushort Get(JSObject obj, int propertyIndex) =>
        Convert.ToUInt16(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, ushort value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, ushort value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableUInt16Accessor : IPropertyAccessor<ushort?>
{
    [SupportedOSPlatform("browser")]
    public static ushort? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToUInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static ushort? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToUInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, ushort? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, ushort? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class Int32Accessor : IUnionMemberAccessor<int>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static int Get(JSObject obj, string propertyName) =>
        Convert.ToInt32(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static int Get(JSObject obj, int propertyIndex) =>
        Convert.ToInt32(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, int value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, int value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableInt32Accessor : IPropertyAccessor<int?>
{
    [SupportedOSPlatform("browser")]
    public static int? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToInt32(res) : null;

    [SupportedOSPlatform("browser")]
    public static int? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToInt32(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, int? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, int? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class UInt32Accessor : IUnionMemberAccessor<uint>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static uint Get(JSObject obj, string propertyName) =>
        Convert.ToUInt32(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static uint Get(JSObject obj, int propertyIndex) =>
        Convert.ToUInt32(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, uint value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, uint value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableUInt32Accessor : IPropertyAccessor<uint?>
{
    [SupportedOSPlatform("browser")]
    public static uint? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToUInt32(res) : null;

    [SupportedOSPlatform("browser")]
    public static uint? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToUInt32(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, uint? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, uint? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class Int64Accessor : IUnionMemberAccessor<long>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static long Get(JSObject obj, string propertyName) =>
        Convert.ToInt64(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static long Get(JSObject obj, int propertyIndex) =>
        Convert.ToInt64(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, long value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, long value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableInt64Accessor : IPropertyAccessor<long?>
{
    [SupportedOSPlatform("browser")]
    public static long? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static long? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, long? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, long? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class UInt64Accessor : IUnionMemberAccessor<ulong>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static ulong Get(JSObject obj, string propertyName) =>
        Convert.ToUInt64(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static ulong Get(JSObject obj, int propertyIndex) =>
        Convert.ToUInt64(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, ulong value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, ulong value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableUInt64Accessor : IPropertyAccessor<ulong?>
{
    [SupportedOSPlatform("browser")]
    public static ulong? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToUInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static ulong? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToUInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, ulong? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, ulong? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class SingleAccessor : IUnionMemberAccessor<float>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static float Get(JSObject obj, string propertyName) =>
        Convert.ToSingle(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static float Get(JSObject obj, int propertyIndex) =>
        Convert.ToSingle(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, float value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, float value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}

public sealed class NullableSingleAccessor : IPropertyAccessor<float?>
{
    [SupportedOSPlatform("browser")]
    public static float? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToSingle(res) : null;

    [SupportedOSPlatform("browser")]
    public static float? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToSingle(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, float? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, float? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}

public sealed class DoubleAccessor : IUnionMemberAccessor<double>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static double Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static double Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, double value) =>
        obj.SetPropertyAsDoubleV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, double value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, value);
}

public sealed class NullableDoubleAccessor : IPropertyAccessor<double?>
{
    [SupportedOSPlatform("browser")]
    public static double? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static double? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, double? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, double? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value);
}

public sealed class BigIntegerAccessor : IUnionMemberAccessor<BigInteger>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.BigInt;

    [SupportedOSPlatform("browser")]
    public static BigInteger Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBigIntegerV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static BigInteger Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBigIntegerV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, BigInteger value) =>
        obj.SetPropertyAsBigIntegerV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, BigInteger value) =>
        obj.SetPropertyAsBigIntegerV2(propertyIndex, value);
}

public sealed class NullableBigIntegerAccessor : IPropertyAccessor<BigInteger?>
{
    [SupportedOSPlatform("browser")]
    public static BigInteger? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBigIntegerV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static BigInteger? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBigIntegerV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, BigInteger? value) =>
        obj.SetPropertyAsBigIntegerV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, BigInteger? value) =>
        obj.SetPropertyAsBigIntegerV2AsNullable(propertyIndex, value);
}

public sealed class StringAccessor : IUnionMemberAccessor<string>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.String;

    [SupportedOSPlatform("browser")]
    public static string Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsStringV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static string Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsStringV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, string value) =>
        obj.SetPropertyAsStringV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, string value) =>
        obj.SetPropertyAsStringV2(propertyIndex, value);
}

public sealed class NullableStringAccessor : IPropertyAccessor<string?>
{
    [SupportedOSPlatform("browser")]
    public static string? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsStringV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static string? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsStringV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, string? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, string? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyIndex, value);
}

public sealed class JSObjectAccessor : IUnionMemberAccessor<JSObject>
{
    public static bool CanRead(JSValueKind kind) => kind is JSValueKind.Object or JSValueKind.Function;

    [SupportedOSPlatform("browser")]
    public static JSObject Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsJSObjectV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static JSObject Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsJSObjectV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, JSObject value) =>
        obj.SetPropertyAsJSObjectV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, JSObject value) =>
        obj.SetPropertyAsJSObjectV2(propertyIndex, value);
}

public sealed class NullableJSObjectAccessor : IPropertyAccessor<JSObject?>
{
    [SupportedOSPlatform("browser")]
    public static JSObject? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static JSObject? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, JSObject? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, JSObject? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyIndex, value);
}

public sealed class ObjectAccessor : IUnionMemberAccessor<object>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.ManagedObject;

    [SupportedOSPlatform("browser")]
    public static object Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsObjectV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static object Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsObjectV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, object value) =>
        obj.SetPropertyAsObjectV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, object value) =>
        obj.SetPropertyAsObjectV2(propertyIndex, value);
}

public sealed class NullableObjectAccessor : IPropertyAccessor<object?>
{
    [SupportedOSPlatform("browser")]
    public static object? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsObjectV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static object? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsObjectV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, object? value) =>
        obj.SetPropertyAsObjectV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, object? value) =>
        obj.SetPropertyAsObjectV2AsNullable(propertyIndex, value);
}
