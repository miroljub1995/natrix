// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CacheQueryOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CacheQueryOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CacheQueryOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreSearch
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreSearch");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreSearch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreMethod
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreMethod");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreMethod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreVary
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreVary");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreVary", value);
    }
}

#nullable disable