// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SnapEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<SnapEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SnapEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SnapEventInit global::Natrix.JSCore.IJSObjectProxy<SnapEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SnapEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SnapTargetBlock
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "snapTargetBlock");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "snapTargetBlock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SnapTargetInline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "snapTargetInline");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "snapTargetInline", value);
    }
}

#nullable disable