// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIInput: global::Natrix.StdWeb.MIDIPort, global::Natrix.JSCore.IJSObjectProxy<MIDIInput>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIInput(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MIDIInput global::Natrix.JSCore.IJSObjectProxy<MIDIInput>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MIDIInput>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmidimessage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onmidimessage");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onmidimessage", value);
    }
}

#nullable disable