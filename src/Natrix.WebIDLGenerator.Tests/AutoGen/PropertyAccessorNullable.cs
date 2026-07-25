// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public class PropertyAccessorNullable:
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<int?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<byte?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<short?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<long?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<float?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<double?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<string?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>?>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? __element_0;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_0 = global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum.Create(___notNullable_1);
        }
        return __element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? __element_0;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_0 = global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum.Create(___notNullable_1);
        }
        return __element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum ___notNullable_1 = (global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum ___notNullable_1 = (global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? __element_1;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_1 = null;
        }
        else
        {
            __element_1 = new global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_0);
        }
        return __element_1;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? __element_1;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_1 = null;
        }
        else
        {
            __element_1 = new global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_0);
        }
        return __element_1;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int? global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        int? __element_2;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_2 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_2 = Convert.ToInt32(___notNullable_1);
        }
        return __element_2;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int? global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        int? __element_2;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_2 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_2 = Convert.ToInt32(___notNullable_1);
        }
        return __element_2;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, int? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            int ___notNullable_1 = (int)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, int? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            int ___notNullable_1 = (int)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool? global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        bool? __element_3;
        bool? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_3 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)___res_0;
            __element_3 = ___notNullable_1;
        }
        return __element_3;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool? global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        bool? __element_3;
        bool? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_3 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)___res_0;
            __element_3 = ___notNullable_1;
        }
        return __element_3;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, bool? value)
    {
        bool? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, bool? value)
    {
        bool? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static byte? global::Natrix.JSCore.Generics.IPropertyAccessor<byte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        byte? __element_4;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_4 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_4 = Convert.ToByte(___notNullable_1);
        }
        return __element_4;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static byte? global::Natrix.JSCore.Generics.IPropertyAccessor<byte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        byte? __element_4;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_4 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_4 = Convert.ToByte(___notNullable_1);
        }
        return __element_4;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<byte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, byte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            byte ___notNullable_1 = (byte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<byte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, byte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            byte ___notNullable_1 = (byte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte? global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        sbyte? __element_5;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_5 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_5 = Convert.ToSByte(___notNullable_1);
        }
        return __element_5;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte? global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        sbyte? __element_5;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_5 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_5 = Convert.ToSByte(___notNullable_1);
        }
        return __element_5;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, sbyte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            sbyte ___notNullable_1 = (sbyte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, sbyte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            sbyte ___notNullable_1 = (sbyte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static short? global::Natrix.JSCore.Generics.IPropertyAccessor<short?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        short? __element_6;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_6 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_6 = Convert.ToInt16(___notNullable_1);
        }
        return __element_6;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static short? global::Natrix.JSCore.Generics.IPropertyAccessor<short?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        short? __element_6;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_6 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_6 = Convert.ToInt16(___notNullable_1);
        }
        return __element_6;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<short?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, short? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            short ___notNullable_1 = (short)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<short?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, short? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            short ___notNullable_1 = (short)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort? global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ushort? __element_7;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_7 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_7 = Convert.ToUInt16(___notNullable_1);
        }
        return __element_7;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort? global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ushort? __element_7;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_7 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_7 = Convert.ToUInt16(___notNullable_1);
        }
        return __element_7;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ushort? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ushort ___notNullable_1 = (ushort)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ushort? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ushort ___notNullable_1 = (ushort)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint? global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        uint? __element_8;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_8 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_8 = Convert.ToUInt32(___notNullable_1);
        }
        return __element_8;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint? global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        uint? __element_8;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_8 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_8 = Convert.ToUInt32(___notNullable_1);
        }
        return __element_8;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, uint? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            uint ___notNullable_1 = (uint)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, uint? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            uint ___notNullable_1 = (uint)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long? global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        long? __element_9;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_9 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_9 = Convert.ToInt64(___notNullable_1);
        }
        return __element_9;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long? global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        long? __element_9;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_9 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_9 = Convert.ToInt64(___notNullable_1);
        }
        return __element_9;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, long? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            long ___notNullable_1 = (long)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, long? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            long ___notNullable_1 = (long)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong? global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ulong? __element_10;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_10 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_10 = Convert.ToUInt64(___notNullable_1);
        }
        return __element_10;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong? global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ulong? __element_10;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_10 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_10 = Convert.ToUInt64(___notNullable_1);
        }
        return __element_10;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ulong? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ulong ___notNullable_1 = (ulong)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ulong? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ulong ___notNullable_1 = (ulong)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float? global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        float? __element_11;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_11 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_11 = Convert.ToSingle(___notNullable_1);
        }
        return __element_11;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float? global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        float? __element_11;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_11 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_11 = Convert.ToSingle(___notNullable_1);
        }
        return __element_11;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, float? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            float ___notNullable_1 = (float)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, float? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            float ___notNullable_1 = (float)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double? global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        double? __element_12;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_12 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_12 = ___notNullable_1;
        }
        return __element_12;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double? global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        double? __element_12;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_12 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_12 = ___notNullable_1;
        }
        return __element_12;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, double? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            double ___notNullable_1 = (double)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, double? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            double ___notNullable_1 = (double)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string? global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        string? __element_13;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_13 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_13 = ___notNullable_1;
        }
        return __element_13;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string? global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        string? __element_13;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_13 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_13 = ___notNullable_1;
        }
        return __element_13;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, string? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, string? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? __element_14;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_14 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_14 = ___notNullable_1;
        }
        return __element_14;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? __element_14;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_14 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_14 = ___notNullable_1;
        }
        return __element_14;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::System.Runtime.InteropServices.JavaScript.JSObject? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::System.Runtime.InteropServices.JavaScript.JSObject? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Numerics.BigInteger? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::System.Numerics.BigInteger? __element_15;
        global::System.Numerics.BigInteger? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBigIntegerV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_15 = null;
        }
        else
        {
            global::System.Numerics.BigInteger ___notNullable_1 = (global::System.Numerics.BigInteger)___res_0;
            __element_15 = ___notNullable_1;
        }
        return __element_15;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Numerics.BigInteger? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::System.Numerics.BigInteger? __element_15;
        global::System.Numerics.BigInteger? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBigIntegerV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_15 = null;
        }
        else
        {
            global::System.Numerics.BigInteger ___notNullable_1 = (global::System.Numerics.BigInteger)___res_0;
            __element_15 = ___notNullable_1;
        }
        return __element_15;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::System.Numerics.BigInteger? value)
    {
        global::System.Numerics.BigInteger? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Numerics.BigInteger ___notNullable_1 = (global::System.Numerics.BigInteger)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBigIntegerV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::System.Numerics.BigInteger? value)
    {
        global::System.Numerics.BigInteger? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Numerics.BigInteger ___notNullable_1 = (global::System.Numerics.BigInteger)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBigIntegerV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? __element_16;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_16 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_16 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>(___notNullable_1);
        }
        return __element_16;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? __element_16;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_16 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_16 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>(___notNullable_1);
        }
        return __element_16;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface ___notNullable_1 = (global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface ___notNullable_1 = (global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? __element_17;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_17 = null;
        }
        else
        {
            __element_17 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_17;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? __element_17;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_17 = null;
        }
        else
        {
            __element_17 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_17;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }
}

#nullable disable
