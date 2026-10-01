// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ServiceWorkerContainer: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<ServiceWorkerContainer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ServiceWorkerContainer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ServiceWorkerContainer global::Natrix.JSCore.IJSObjectProxy<ServiceWorkerContainer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ServiceWorkerContainer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ServiceWorker? Controller
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ServiceWorker>.Get(JSObject, "controller");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>> Ready
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>.Get(JSObject, "ready");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>> Register(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> scriptURL)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = scriptURL.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "register", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>> Register(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> scriptURL, global::Natrix.StdWeb.RegistrationOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = scriptURL.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "register", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>> GetRegistration()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getRegistration", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>> GetRegistration(string clientURL)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = clientURL;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getRegistration", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ServiceWorkerRegistration?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>> GetRegistrations()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getRegistrations", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ServiceWorkerRegistration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration>>>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void StartMessages()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "startMessages", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oncontrollerchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "oncontrollerchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "oncontrollerchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmessage
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onmessage");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onmessage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmessageerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onmessageerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onmessageerror", value);
    }
}

#nullable disable