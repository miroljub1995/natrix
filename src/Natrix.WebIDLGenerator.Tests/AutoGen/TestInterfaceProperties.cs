// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestInterfaceProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestInterfaceProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullableReadonlyAsNotNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullableReadonlyAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface? ValueNullableReadonlyAsNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestInterfacePropertiesInterface?, global::Natrix.WebIDLGenerator.Tests.PropertyAccessorNullable>(JSObject, "valueNullableReadonlyAsNull");
    }
}

#nullable disable