// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestInterfacePropertiesInterface: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestInterfacePropertiesInterface(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value", value);
    }
}

#nullable disable