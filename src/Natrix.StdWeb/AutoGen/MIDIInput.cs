// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIInput: global::Natrix.StdWeb.MIDIPort
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIInput(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmidimessage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onmidimessage");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onmidimessage", value);
    }
}

#nullable disable