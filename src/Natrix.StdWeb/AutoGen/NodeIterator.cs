// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NodeIterator: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NodeIterator>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NodeIterator(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NodeIterator global::Natrix.JSCore.IJSObjectProxy<NodeIterator>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NodeIterator>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node Root
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "root");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node ReferenceNode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "referenceNode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PointerBeforeReferenceNode
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "pointerBeforeReferenceNode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint WhatToShow
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "whatToShow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeFilter? Filter
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.NodeFilter>.Get(JSObject, "filter");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? NextNode()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "nextNode", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? PreviousNode()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "previousNode", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Detach()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "detach", JSObject);
    }
}

#nullable disable