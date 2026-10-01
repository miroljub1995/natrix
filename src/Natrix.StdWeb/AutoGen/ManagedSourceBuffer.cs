// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ManagedSourceBuffer: global::Natrix.StdWeb.SourceBuffer, global::Natrix.JSCore.IJSObjectProxy<ManagedSourceBuffer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ManagedSourceBuffer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ManagedSourceBuffer global::Natrix.JSCore.IJSObjectProxy<ManagedSourceBuffer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ManagedSourceBuffer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onbufferedchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onbufferedchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onbufferedchange", value);
    }
}

#nullable disable