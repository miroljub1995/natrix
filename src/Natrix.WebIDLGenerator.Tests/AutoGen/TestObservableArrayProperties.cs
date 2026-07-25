// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestObservableArrayProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestObservableArrayProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> BoolObservableArray
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "boolObservableArray");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "boolObservableArray", value);
    }
}

#nullable disable