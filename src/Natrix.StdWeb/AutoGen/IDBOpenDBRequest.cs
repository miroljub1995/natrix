// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IDBOpenDBRequest: global::Natrix.StdWeb.IDBRequest, global::Natrix.JSCore.IJSObjectProxy<IDBOpenDBRequest>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBOpenDBRequest(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IDBOpenDBRequest global::Natrix.JSCore.IJSObjectProxy<IDBOpenDBRequest>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IDBOpenDBRequest>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onblocked
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onblocked");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onblocked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onupgradeneeded
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onupgradeneeded");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onupgradeneeded", value);
    }
}

#nullable disable