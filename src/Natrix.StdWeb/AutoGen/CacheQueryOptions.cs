// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CacheQueryOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CacheQueryOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CacheQueryOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CacheQueryOptions global::Natrix.JSCore.IJSObjectProxy<CacheQueryOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CacheQueryOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreSearch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreSearch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ignoreSearch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreMethod
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreMethod");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ignoreMethod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreVary
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreVary");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ignoreVary", value);
    }
}

#nullable disable