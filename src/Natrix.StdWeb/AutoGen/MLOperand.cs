// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLOperand: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLOperand>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLOperand(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLOperand global::Natrix.JSCore.IJSObjectProxy<MLOperand>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MLOperand>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperandDataType DataType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>.Get(JSObject, "dataType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor> Shape
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "shape");
    }
}

#nullable disable