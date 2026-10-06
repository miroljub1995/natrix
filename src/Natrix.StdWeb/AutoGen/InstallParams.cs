// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InstallParams: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<InstallParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InstallParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InstallParams global::Natrix.JSCore.IJSObjectProxy<InstallParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InstallParams(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Manifest
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "manifest");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "manifest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ManifestId
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "manifestId");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "manifestId", value);
    }
}

#nullable disable