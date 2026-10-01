// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MIDIOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MIDIOptions global::Natrix.JSCore.IJSObjectProxy<MIDIOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Sysex
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "sysex");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "sysex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Software
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "software");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "software", value);
    }
}

#nullable disable