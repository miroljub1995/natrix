// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FederatedCredentialInit: global::Natrix.StdWeb.CredentialData, global::Natrix.JSCore.IJSObjectProxy<FederatedCredentialInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FederatedCredentialInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FederatedCredentialInit global::Natrix.JSCore.IJSObjectProxy<FederatedCredentialInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FederatedCredentialInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string IconURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "iconURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "iconURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Provider
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "provider");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "provider", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }
}

#nullable disable