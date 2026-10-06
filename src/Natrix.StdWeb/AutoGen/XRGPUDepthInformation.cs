// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUDepthInformation: global::Natrix.StdWeb.XRDepthInformation, global::Natrix.JSCore.IJSObjectProxy<XRGPUDepthInformation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUDepthInformation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPUDepthInformation global::Natrix.JSCore.IJSObjectProxy<XRGPUDepthInformation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRGPUDepthInformation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture Texture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>.Get(JSObject, "texture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDescriptor GetViewDescriptor()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getViewDescriptor", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureViewDescriptor>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable