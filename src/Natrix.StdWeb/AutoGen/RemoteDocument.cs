// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RemoteDocument: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RemoteDocument>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RemoteDocument(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RemoteDocument global::Natrix.JSCore.IJSObjectProxy<RemoteDocument>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RemoteDocument>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RemoteDocument New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RemoteDocument");
        return new global::Natrix.StdWeb.RemoteDocument(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContextUrl
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contextUrl");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Document
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "document");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "document", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentUrl
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "documentUrl");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Profile
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "profile");
    }
}

#nullable disable