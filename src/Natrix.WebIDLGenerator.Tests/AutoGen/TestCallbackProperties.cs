// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestCallbackProperties: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback VoidCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "voidCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "voidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int CallVoidCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "callVoidCallbackOnSet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "callVoidCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback VariadicCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "variadicCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesVariadicCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "variadicCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor> CallVariadicCallbackOnSet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "callVariadicCallbackOnSet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "callVariadicCallbackOnSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback NonVoidCallback
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "nonVoidCallback");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackPropertiesNonVoidCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "nonVoidCallback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int NonVoidCallbackCallAndGetResult
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "nonVoidCallbackCallAndGetResult");
    }
}

#nullable disable