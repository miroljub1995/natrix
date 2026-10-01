// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdleRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdleRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdleRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdleRequestOptions global::Natrix.JSCore.IJSObjectProxy<IdleRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdleRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Timeout
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "timeout");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "timeout", value);
    }
}

#nullable disable