// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IDBVersionChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<IDBVersionChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBVersionChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IDBVersionChangeEventInit global::Natrix.JSCore.IJSObjectProxy<IDBVersionChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBVersionChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong OldVersion
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "oldVersion");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "oldVersion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? NewVersion
    {
        get => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Get(JSObject, "newVersion");
        set => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Set(JSObject, "newVersion", value);
    }
}

#nullable disable