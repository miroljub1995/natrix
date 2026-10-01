// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestObservableArrayProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestObservableArrayProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestObservableArrayProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestObservableArrayProperties global::Natrix.JSCore.IJSObjectProxy<TestObservableArrayProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestObservableArrayProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> BoolObservableArray
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "boolObservableArray");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "boolObservableArray", value);
    }
}

#nullable disable