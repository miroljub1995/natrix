// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DecompressionStream: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DecompressionStream>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DecompressionStream(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DecompressionStream global::Natrix.JSCore.IJSObjectProxy<DecompressionStream>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DecompressionStream>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.DecompressionStream New(global::Natrix.StdWeb.CompressionFormat format)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = format.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DecompressionStream", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.DecompressionStream(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStream Readable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Get(JSObject, "readable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WritableStream Writable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WritableStream>.Get(JSObject, "writable");
    }
}

#nullable disable