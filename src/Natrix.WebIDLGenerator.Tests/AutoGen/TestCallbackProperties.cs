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
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Get(JSObject, "voidCallback");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback>.Set(JSObject, "voidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int CallVoidCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "callVoidCallbackOnSet");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "callVoidCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback VariadicCallback
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Get(JSObject, "variadicCallback");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback>.Set(JSObject, "variadicCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor> CallVariadicCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "callVariadicCallbackOnSet");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "callVariadicCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback NonVoidCallback
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Get(JSObject, "nonVoidCallback");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback>.Set(JSObject, "nonVoidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int NonVoidCallbackCallAndGetResult
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "nonVoidCallbackCallAndGetResult");
    }
}

#nullable disable