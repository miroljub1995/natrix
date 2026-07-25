// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestUnionProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestUnionProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union> Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.WebIDLGenerator.Tests.GenericMarshaller.Union>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "value", value);
    }
}

#nullable disable