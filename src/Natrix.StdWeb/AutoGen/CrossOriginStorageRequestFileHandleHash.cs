// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CrossOriginStorageRequestFileHandleHash: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CrossOriginStorageRequestFileHandleHash>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrossOriginStorageRequestFileHandleHash(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CrossOriginStorageRequestFileHandleHash global::Natrix.JSCore.IJSObjectProxy<CrossOriginStorageRequestFileHandleHash>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrossOriginStorageRequestFileHandleHash(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Algorithm
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "algorithm");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "algorithm", value);
    }
}

#nullable disable