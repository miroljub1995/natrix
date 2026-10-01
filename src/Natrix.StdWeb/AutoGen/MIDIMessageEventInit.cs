// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIMessageEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<MIDIMessageEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIMessageEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MIDIMessageEventInit global::Natrix.JSCore.IJSObjectProxy<MIDIMessageEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIMessageEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Uint8Array Data
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>.Set(JSObject, "data", value);
    }
}

#nullable disable