// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MutationRecord: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MutationRecord(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node Target
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList AddedNodes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NodeList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addedNodes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList RemovedNodes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NodeList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "removedNodes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? PreviousSibling
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "previousSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? NextSibling
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "nextSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AttributeName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "attributeName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AttributeNamespace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "attributeNamespace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? OldValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "oldValue");
    }
}

#nullable disable