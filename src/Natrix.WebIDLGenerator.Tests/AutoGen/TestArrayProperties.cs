// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestArrayProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestArrayProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestArrayProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestArrayProperties global::Natrix.JSCore.IJSObjectProxy<TestArrayProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestArrayProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> BoolArray
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "boolArray");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "boolArray", value);
    }
}

#nullable disable