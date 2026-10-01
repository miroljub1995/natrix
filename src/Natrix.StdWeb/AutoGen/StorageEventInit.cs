// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StorageEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<StorageEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StorageEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StorageEventInit global::Natrix.JSCore.IJSObjectProxy<StorageEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StorageEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Key
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "key");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "key", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? OldValue
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "oldValue");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "oldValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? NewValue
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "newValue");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "newValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Storage? StorageArea
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Storage>.Get(JSObject, "storageArea");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Storage>.Set(JSObject, "storageArea", value);
    }
}

#nullable disable