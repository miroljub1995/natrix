// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ManagedSourceBuffer: global::Natrix.StdWeb.SourceBuffer
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ManagedSourceBuffer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onbufferedchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onbufferedchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onbufferedchange", value);
    }
}

#nullable disable