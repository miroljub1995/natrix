// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestCallbackProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestCallbackProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestCallbackProperties global::Natrix.JSCore.IJSObjectProxy<TestCallbackProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestCallbackProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback VoidCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>>(JSObject, "voidCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>>(JSObject, "voidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int CallVoidCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "callVoidCallbackOnSet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "callVoidCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback VariadicCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>>(JSObject, "variadicCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>>(JSObject, "variadicCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor> CallVariadicCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>>>(JSObject, "callVariadicCallbackOnSet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>>>(JSObject, "callVariadicCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback NonVoidCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>>(JSObject, "nonVoidCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>>(JSObject, "nonVoidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int NonVoidCallbackCallAndGetResult
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "nonVoidCallbackCallAndGetResult");
    }
}

#nullable disable