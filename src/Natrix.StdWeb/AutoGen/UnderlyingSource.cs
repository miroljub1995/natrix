// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UnderlyingSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<UnderlyingSource>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static UnderlyingSource global::Natrix.JSCore.IJSObjectProxy<UnderlyingSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSource(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourceStartCallback Start
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourceStartCallback>.Get(JSObject, "start");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourceStartCallback>.Set(JSObject, "start", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourcePullCallback Pull
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourcePullCallback>.Get(JSObject, "pull");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourcePullCallback>.Set(JSObject, "pull", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourceCancelCallback Cancel
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourceCancelCallback>.Get(JSObject, "cancel");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UnderlyingSourceCancelCallback>.Set(JSObject, "cancel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStreamType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong AutoAllocateChunkSize
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "autoAllocateChunkSize");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "autoAllocateChunkSize", value);
    }
}

#nullable disable