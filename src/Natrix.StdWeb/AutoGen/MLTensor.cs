// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLTensor: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLTensor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTensor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLTensor global::Natrix.JSCore.IJSObjectProxy<MLTensor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MLTensor>(obj);

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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Readable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "readable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Writable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "writable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Constant
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "constant");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Destroy()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "destroy", JSObject);
    }
}

#nullable disable