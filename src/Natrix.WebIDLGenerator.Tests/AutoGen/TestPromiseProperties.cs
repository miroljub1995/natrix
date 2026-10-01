// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestPromiseProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestPromiseProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestPromiseProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestPromiseProperties global::Natrix.JSCore.IJSObjectProxy<TestPromiseProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestPromiseProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor> PromisePropertyLong
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLong");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "promisePropertyLong", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor> PromisePropertyLongReadOnly
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLongReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>? PromisePropertyLongNullable
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLongNullable");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "promisePropertyLongNullable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>? PromisePropertyLongReadOnlyNullableAsNull
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLongReadOnlyNullableAsNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>? PromisePropertyLongReadOnlyNullableAsNotNull
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLongReadOnlyNullableAsNotNull");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor> PromisePropertyString
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "promisePropertyString");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "promisePropertyString", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor> PromisePropertyStringReadOnly
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "promisePropertyStringReadOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor> PromisePropertyLongDelayed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "promisePropertyLongDelayed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor> TestTaskToPromise
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Get(JSObject, "testTaskToPromise");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<int, global::Natrix.JSCore.Generics.Int32Accessor>>.Set(JSObject, "testTaskToPromise", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? TestTaskToPromiseValue
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "testTaskToPromiseValue");
        set => global::Natrix.JSCore.Generics.NullableInt32Accessor.Set(JSObject, "testTaskToPromiseValue", value);
    }
}

#nullable disable