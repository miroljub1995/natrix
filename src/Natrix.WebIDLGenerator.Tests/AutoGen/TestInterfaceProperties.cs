// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestInterfaceProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestInterfaceProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestInterfaceProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestInterfaceProperties global::Natrix.JSCore.IJSObjectProxy<TestInterfaceProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestInterfaceProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface Value
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullable
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(JSObject, "valueNullable");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Set(JSObject, "valueNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullableReadonlyAsNotNull
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(JSObject, "valueNullableReadonlyAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullableReadonlyAsNull
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface>.Get(JSObject, "valueNullableReadonlyAsNull");
    }
}

#nullable disable