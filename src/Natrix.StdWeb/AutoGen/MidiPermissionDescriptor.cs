// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MidiPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<MidiPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MidiPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MidiPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<MidiPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MidiPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Sysex
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "sysex");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "sysex", value);
    }
}

#nullable disable