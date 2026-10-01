// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestProperties global::Natrix.JSCore.IJSObjectProxy<TestProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BoolProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "boolProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "boolProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BoolPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "boolPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? BoolPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "boolPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "boolPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? BoolPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "boolPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? BoolPropertyReadOnlyNullableAsTrue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "boolPropertyReadOnlyNullableAsTrue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? BoolPropertyReadOnlyNullableAsFalse
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "boolPropertyReadOnlyNullableAsFalse");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte ByteProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.JSCore.Generics.ByteAccessor>(JSObject, "byteProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.JSCore.Generics.ByteAccessor>(JSObject, "byteProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte BytePropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.JSCore.Generics.ByteAccessor>(JSObject, "bytePropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte? BytePropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte?, global::Natrix.JSCore.Generics.NullableByteAccessor>(JSObject, "bytePropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte?, global::Natrix.JSCore.Generics.NullableByteAccessor>(JSObject, "bytePropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte? BytePropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte?, global::Natrix.JSCore.Generics.NullableByteAccessor>(JSObject, "bytePropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte? BytePropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte?, global::Natrix.JSCore.Generics.NullableByteAccessor>(JSObject, "bytePropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte SignedByteProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.JSCore.Generics.SByteAccessor>(JSObject, "signedByteProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.JSCore.Generics.SByteAccessor>(JSObject, "signedByteProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte SignedBytePropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.JSCore.Generics.SByteAccessor>(JSObject, "signedBytePropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte? SignedBytePropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "signedBytePropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "signedBytePropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte? SignedBytePropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "signedBytePropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte? SignedBytePropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "signedBytePropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short ShortProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short, global::Natrix.JSCore.Generics.Int16Accessor>(JSObject, "shortProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<short, global::Natrix.JSCore.Generics.Int16Accessor>(JSObject, "shortProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short ShortPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short, global::Natrix.JSCore.Generics.Int16Accessor>(JSObject, "shortPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short? ShortPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short?, global::Natrix.JSCore.Generics.NullableInt16Accessor>(JSObject, "shortPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<short?, global::Natrix.JSCore.Generics.NullableInt16Accessor>(JSObject, "shortPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short? ShortPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short?, global::Natrix.JSCore.Generics.NullableInt16Accessor>(JSObject, "shortPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short? ShortPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short?, global::Natrix.JSCore.Generics.NullableInt16Accessor>(JSObject, "shortPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UnsignedShortProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "unsignedShortProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "unsignedShortProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UnsignedShortPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "unsignedShortPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? UnsignedShortPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "unsignedShortPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "unsignedShortPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? UnsignedShortPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "unsignedShortPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? UnsignedShortPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "unsignedShortPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Int32Property
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "int32Property");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "int32Property", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Int32PropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "int32PropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? Int32PropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "int32PropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "int32PropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? Int32PropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "int32PropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? Int32PropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "int32PropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UnsignedInt32Property
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "unsignedInt32Property");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "unsignedInt32Property", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UnsignedInt32PropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "unsignedInt32PropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? UnsignedInt32PropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "unsignedInt32PropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "unsignedInt32PropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? UnsignedInt32PropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "unsignedInt32PropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? UnsignedInt32PropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "unsignedInt32PropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long Int64Property
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "int64Property");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "int64Property", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long Int64PropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "int64PropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long? Int64PropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "int64PropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "int64PropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long? Int64PropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "int64PropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long? Int64PropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "int64PropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnsignedInt64Property
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "unsignedInt64Property");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "unsignedInt64Property", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnsignedInt64PropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "unsignedInt64PropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? UnsignedInt64PropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "unsignedInt64PropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "unsignedInt64PropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? UnsignedInt64PropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "unsignedInt64PropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? UnsignedInt64PropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "unsignedInt64PropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float FloatProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "floatProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "floatProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float FloatPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "floatPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FloatPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "floatPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "floatPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FloatPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "floatPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FloatPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "floatPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float UnrestrictedFloatProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "unrestrictedFloatProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "unrestrictedFloatProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float UnrestrictedFloatPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "unrestrictedFloatPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? UnrestrictedFloatPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "unrestrictedFloatPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "unrestrictedFloatPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? UnrestrictedFloatPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "unrestrictedFloatPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? UnrestrictedFloatPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "unrestrictedFloatPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DoubleProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "doubleProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "doubleProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DoublePropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "doublePropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? DoublePropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "doublePropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "doublePropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? DoublePropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "doublePropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? DoublePropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "doublePropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnrestrictedDoubleProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "unrestrictedDoubleProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "unrestrictedDoubleProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnrestrictedDoublePropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "unrestrictedDoublePropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? UnrestrictedDoublePropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "unrestrictedDoublePropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "unrestrictedDoublePropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? UnrestrictedDoublePropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "unrestrictedDoublePropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? UnrestrictedDoublePropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "unrestrictedDoublePropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StringProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "stringProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "stringProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StringPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "stringPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? StringPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "stringPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "stringPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? StringPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "stringPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? StringPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "stringPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? StringPropertyReadOnlyNullableAsEmpty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "stringPropertyReadOnlyNullableAsEmpty");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ObjectProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(JSObject, "objectProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(JSObject, "objectProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ObjectPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(JSObject, "objectPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? ObjectPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject?, global::Natrix.JSCore.Generics.NullableJSObjectAccessor>(JSObject, "objectPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Runtime.InteropServices.JavaScript.JSObject?, global::Natrix.JSCore.Generics.NullableJSObjectAccessor>(JSObject, "objectPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? ObjectPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject?, global::Natrix.JSCore.Generics.NullableJSObjectAccessor>(JSObject, "objectPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? ObjectPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject?, global::Natrix.JSCore.Generics.NullableJSObjectAccessor>(JSObject, "objectPropertyReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Numerics.BigInteger BigIntProperty
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.BigIntegerAccessor>(JSObject, "bigIntProperty");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.BigIntegerAccessor>(JSObject, "bigIntProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Numerics.BigInteger BigIntPropertyReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.BigIntegerAccessor>(JSObject, "bigIntPropertyReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Numerics.BigInteger? BigIntPropertyNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Numerics.BigInteger?, global::Natrix.JSCore.Generics.NullableBigIntegerAccessor>(JSObject, "bigIntPropertyNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Numerics.BigInteger?, global::Natrix.JSCore.Generics.NullableBigIntegerAccessor>(JSObject, "bigIntPropertyNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Numerics.BigInteger? BigIntPropertyReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Numerics.BigInteger?, global::Natrix.JSCore.Generics.NullableBigIntegerAccessor>(JSObject, "bigIntPropertyReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Numerics.BigInteger? BigIntPropertyReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Numerics.BigInteger?, global::Natrix.JSCore.Generics.NullableBigIntegerAccessor>(JSObject, "bigIntPropertyReadOnlyNullableAsNotNull");
    }
}

#nullable disable