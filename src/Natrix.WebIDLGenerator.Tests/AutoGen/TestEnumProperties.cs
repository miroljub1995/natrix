// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestEnumProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestEnumProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestEnumProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestEnumProperties global::Natrix.JSCore.IJSObjectProxy<TestEnumProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestEnumProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "valueNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "valueNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullableReadonlyAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "valueNullableReadonlyAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullableReadonlyAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "valueNullableReadonlyAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueInvalid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum>>(JSObject, "valueInvalid");
    }
}

#nullable disable