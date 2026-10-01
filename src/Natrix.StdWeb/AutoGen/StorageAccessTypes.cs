// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StorageAccessTypes: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<StorageAccessTypes>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StorageAccessTypes(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StorageAccessTypes global::Natrix.JSCore.IJSObjectProxy<StorageAccessTypes>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StorageAccessTypes(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool All
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "all");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "all", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Cookies
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "cookies");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "cookies", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SessionStorage
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "sessionStorage");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "sessionStorage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool LocalStorage
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "localStorage");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "localStorage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IndexedDB
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "indexedDB");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "indexedDB", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Locks
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "locks");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "locks", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Caches
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "caches");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "caches", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool GetDirectory
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "getDirectory");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "getDirectory", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Estimate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "estimate");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "estimate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CreateObjectURL
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "createObjectURL");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "createObjectURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RevokeObjectURL
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "revokeObjectURL");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "revokeObjectURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BroadcastChannel
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "BroadcastChannel");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "BroadcastChannel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SharedWorker
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "SharedWorker");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "SharedWorker", value);
    }
}

#nullable disable