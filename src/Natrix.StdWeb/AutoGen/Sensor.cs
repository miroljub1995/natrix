// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Sensor: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<Sensor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Sensor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Sensor global::Natrix.JSCore.IJSObjectProxy<Sensor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Sensor>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Activated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "activated");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasReading
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasReading");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Timestamp
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "timestamp");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "start", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Stop()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stop", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onreading
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onreading");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onreading", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onactivate
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onactivate");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onactivate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onerror", value);
    }
}

#nullable disable