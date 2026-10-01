// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XPathResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XPathResult>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XPathResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XPathResult global::Natrix.JSCore.IJSObjectProxy<XPathResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XPathResult>(obj);

    public const ushort ANY_TYPE = 0;

    public const ushort NUMBER_TYPE = 1;

    public const ushort STRING_TYPE = 2;

    public const ushort BOOLEAN_TYPE = 3;

    public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;

    public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;

    public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;

    public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;

    public const ushort ANY_UNORDERED_NODE_TYPE = 8;

    public const ushort FIRST_ORDERED_NODE_TYPE = 9;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ResultType
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "resultType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double NumberValue
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "numberValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StringValue
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "stringValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BooleanValue
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "booleanValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SingleNodeValue
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "singleNodeValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool InvalidIteratorState
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "invalidIteratorState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SnapshotLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "snapshotLength");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? IterateNext()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "iterateNext", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SnapshotItem(uint index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "snapshotItem", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable