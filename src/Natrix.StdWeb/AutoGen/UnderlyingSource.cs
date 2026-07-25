// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UnderlyingSource: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UnderlyingSource(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourceStartCallback Start
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.UnderlyingSourceStartCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "start");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.UnderlyingSourceStartCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "start", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourcePullCallback Pull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.UnderlyingSourcePullCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pull");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.UnderlyingSourcePullCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pull", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlyingSourceCancelCallback Cancel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.UnderlyingSourceCancelCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cancel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.UnderlyingSourceCancelCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cancel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStreamType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ReadableStreamType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ReadableStreamType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong AutoAllocateChunkSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "autoAllocateChunkSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "autoAllocateChunkSize", value);
    }
}

#nullable disable