// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestEnumProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestEnumProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullableReadonlyAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullableReadonlyAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueNullableReadonlyAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullableReadonlyAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum? ValueInvalid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestEnumPropertiesEnum?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueInvalid");
    }
}

#nullable disable