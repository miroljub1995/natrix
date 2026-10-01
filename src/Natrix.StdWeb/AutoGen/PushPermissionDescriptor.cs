// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<PushPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PushPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<PushPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UserVisibleOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "userVisibleOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "userVisibleOnly", value);
    }
}

#nullable disable