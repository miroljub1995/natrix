// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaHashedKeyGenParams: global::Natrix.StdWeb.RsaKeyGenParams, global::Natrix.JSCore.IJSObjectProxy<RsaHashedKeyGenParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyGenParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaHashedKeyGenParams global::Natrix.JSCore.IJSObjectProxy<RsaHashedKeyGenParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyGenParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor> Hash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "hash", value);
    }
}

#nullable disable