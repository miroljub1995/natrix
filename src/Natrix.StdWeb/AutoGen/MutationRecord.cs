// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MutationRecord: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MutationRecord>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MutationRecord(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MutationRecord global::Natrix.JSCore.IJSObjectProxy<MutationRecord>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MutationRecord>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList AddedNodes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "addedNodes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList RemovedNodes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "removedNodes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? PreviousSibling
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "previousSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? NextSibling
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "nextSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AttributeName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "attributeName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AttributeNamespace
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "attributeNamespace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? OldValue
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "oldValue");
    }
}

#nullable disable