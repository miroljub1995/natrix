// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DOMParser: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DOMParser>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DOMParser(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DOMParser global::Natrix.JSCore.IJSObjectProxy<DOMParser>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DOMParser>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.DOMParser New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DOMParser");
        return new global::Natrix.StdWeb.DOMParser(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Document ParseFromString(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> @string, global::Natrix.StdWeb.DOMParserSupportedType type)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = @string.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = type.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "parseFromString", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable