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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, int, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.Int32Accessor, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "value", value);
    }
}

#nullable disable