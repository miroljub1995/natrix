// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaHashedImportParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<RsaHashedImportParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedImportParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaHashedImportParams global::Natrix.JSCore.IJSObjectProxy<RsaHashedImportParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedImportParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor> Hash
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "hash", value);
    }
}

#nullable disable