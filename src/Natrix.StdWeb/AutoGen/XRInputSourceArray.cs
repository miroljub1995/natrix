// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRInputSourceArray: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRInputSourceArray>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSourceArray(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRInputSourceArray global::Natrix.JSCore.IJSObjectProxy<XRInputSourceArray>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRInputSourceArray>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRInputSource Get(uint index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallGetter(JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable