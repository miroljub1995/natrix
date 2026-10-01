// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PermissionSetParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PermissionSetParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionSetParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PermissionSetParameters global::Natrix.JSCore.IJSObjectProxy<PermissionSetParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionSetParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::System.Runtime.InteropServices.JavaScript.JSObject Descriptor
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "descriptor");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "descriptor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PermissionState State
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>.Get(JSObject, "state");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>.Set(JSObject, "state", value);
    }
}

#nullable disable