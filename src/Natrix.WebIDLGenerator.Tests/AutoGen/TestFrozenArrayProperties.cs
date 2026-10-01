// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestFrozenArrayProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestFrozenArrayProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestFrozenArrayProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestFrozenArrayProperties global::Natrix.JSCore.IJSObjectProxy<TestFrozenArrayProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestFrozenArrayProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> BoolArray
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "boolArray");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "boolArray", value);
    }
}

#nullable disable