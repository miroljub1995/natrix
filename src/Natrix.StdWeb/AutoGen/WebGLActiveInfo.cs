// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebGLActiveInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebGLActiveInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebGLActiveInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebGLActiveInfo global::Natrix.JSCore.IJSObjectProxy<WebGLActiveInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebGLActiveInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Size
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "size");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Type
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }
}

#nullable disable