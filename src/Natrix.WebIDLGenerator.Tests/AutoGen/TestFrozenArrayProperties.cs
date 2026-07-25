// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestFrozenArrayProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestFrozenArrayProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> BoolArray
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "boolArray");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "boolArray", value);
    }
}

#nullable disable