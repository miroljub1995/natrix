// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public class PropertyAccessor:
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<int>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<string>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<bool>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<byte>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<short>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ushort>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<uint>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<long>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ulong>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<float>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<double>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum ___element_0;
        string ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(obj, propertyIndex);
        ___element_0 = global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum.Create(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum ___element_0;
        string ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(obj, propertyName);
        ___element_0 = global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum.Create(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum value)
    {
        string ___marshalledValue_0;
        ___marshalledValue_0 = value.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum value)
    {
        string ___marshalledValue_0;
        ___marshalledValue_0 = value.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int global::Natrix.JSCore.Generics.IPropertyAccessor<int>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        int ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToInt32(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int global::Natrix.JSCore.Generics.IPropertyAccessor<int>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        int ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToInt32(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, int value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, int value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Promise<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string global::Natrix.JSCore.Generics.IPropertyAccessor<string>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        string ___element_0;
        string ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(obj, propertyIndex);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string global::Natrix.JSCore.Generics.IPropertyAccessor<string>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        string ___element_0;
        string ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(obj, propertyName);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, string value)
    {
        string ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, string value)
    {
        string ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Promise<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool global::Natrix.JSCore.Generics.IPropertyAccessor<bool>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        bool ___element_0;
        bool ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2(obj, propertyIndex);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool global::Natrix.JSCore.Generics.IPropertyAccessor<bool>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        bool ___element_0;
        bool ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2(obj, propertyName);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, bool value)
    {
        bool ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, bool value)
    {
        bool ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static byte global::Natrix.JSCore.Generics.IPropertyAccessor<byte>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        byte ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToByte(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static byte global::Natrix.JSCore.Generics.IPropertyAccessor<byte>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        byte ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToByte(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<byte>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, byte value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<byte>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, byte value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        sbyte ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToSByte(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        sbyte ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToSByte(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, sbyte value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, sbyte value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static short global::Natrix.JSCore.Generics.IPropertyAccessor<short>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        short ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToInt16(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static short global::Natrix.JSCore.Generics.IPropertyAccessor<short>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        short ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToInt16(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<short>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, short value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<short>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, short value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort global::Natrix.JSCore.Generics.IPropertyAccessor<ushort>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ushort ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToUInt16(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort global::Natrix.JSCore.Generics.IPropertyAccessor<ushort>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ushort ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToUInt16(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ushort value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ushort value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint global::Natrix.JSCore.Generics.IPropertyAccessor<uint>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        uint ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToUInt32(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint global::Natrix.JSCore.Generics.IPropertyAccessor<uint>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        uint ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToUInt32(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, uint value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, uint value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long global::Natrix.JSCore.Generics.IPropertyAccessor<long>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        long ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToInt64(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long global::Natrix.JSCore.Generics.IPropertyAccessor<long>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        long ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToInt64(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, long value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, long value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong global::Natrix.JSCore.Generics.IPropertyAccessor<ulong>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ulong ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToUInt64(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong global::Natrix.JSCore.Generics.IPropertyAccessor<ulong>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ulong ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToUInt64(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ulong value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ulong value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float global::Natrix.JSCore.Generics.IPropertyAccessor<float>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        float ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = Convert.ToSingle(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float global::Natrix.JSCore.Generics.IPropertyAccessor<float>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        float ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = Convert.ToSingle(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, float value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, float value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = Convert.ToDouble(value);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double global::Natrix.JSCore.Generics.IPropertyAccessor<double>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        double ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyIndex);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double global::Natrix.JSCore.Generics.IPropertyAccessor<double>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        double ___element_0;
        double ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(obj, propertyName);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, double value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, double value)
    {
        double ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::System.Runtime.InteropServices.JavaScript.JSObject value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::System.Runtime.InteropServices.JavaScript.JSObject value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Numerics.BigInteger global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::System.Numerics.BigInteger ___element_0;
        global::System.Numerics.BigInteger ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBigIntegerV2(obj, propertyIndex);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Numerics.BigInteger global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::System.Numerics.BigInteger ___element_0;
        global::System.Numerics.BigInteger ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBigIntegerV2(obj, propertyName);
        ___element_0 = ___res_1;
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::System.Numerics.BigInteger value)
    {
        global::System.Numerics.BigInteger ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBigIntegerV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Numerics.BigInteger>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::System.Numerics.BigInteger value)
    {
        global::System.Numerics.BigInteger ___marshalledValue_0;
        ___marshalledValue_0 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBigIntegerV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Record<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback(___res_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_0;
        ___marshalledValue_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyIndex);
        ___element_0 = new global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> ___element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_1;
        ___propObject_1 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(obj, propertyName);
        ___element_0 = new global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(___propObject_1);
        return ___element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Record<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_0 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(obj, propertyName, ___propObject_0);
    }
}

#nullable disable
