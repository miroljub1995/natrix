// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HmacKeyGenParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<HmacKeyGenParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HmacKeyGenParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HmacKeyGenParams global::Natrix.JSCore.IJSObjectProxy<HmacKeyGenParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HmacKeyGenParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor> Hash
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Runtime.InteropServices.JavaScript.JSObject, string, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "hash", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "length", value);
    }
}

#nullable disable