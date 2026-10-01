// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestUnionProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestUnionProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestUnionProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestUnionProperties global::Natrix.JSCore.IJSObjectProxy<TestUnionProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestUnionProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor> Value
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, int, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>, global::Natrix.JSCore.Generics.Int32Accessor> EnumValue
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, int, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "enumValue");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, int, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "enumValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, int, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>, global::Natrix.JSCore.Generics.Int32Accessor> CallbackValue
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, int, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "callbackValue");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, int, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "callbackValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int CallCallbackValueOnSet
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "callCallbackValueOnSet");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "callCallbackValueOnSet", value);
    }
}

#nullable disable