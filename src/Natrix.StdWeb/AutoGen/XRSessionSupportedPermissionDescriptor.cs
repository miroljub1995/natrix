// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRSessionSupportedPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<XRSessionSupportedPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSessionSupportedPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRSessionSupportedPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<XRSessionSupportedPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSessionSupportedPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSessionMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRSessionMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRSessionMode>.Set(JSObject, "mode", value);
    }
}

#nullable disable