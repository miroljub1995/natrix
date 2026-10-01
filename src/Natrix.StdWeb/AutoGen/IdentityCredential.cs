// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdentityCredential: global::Natrix.StdWeb.Credential, global::Natrix.JSCore.IJSObjectProxy<IdentityCredential>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityCredential(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdentityCredential global::Natrix.JSCore.IJSObjectProxy<IdentityCredential>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IdentityCredential>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Promise Disconnect(global::Natrix.StdWeb.IdentityCredentialDisconnectOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "IdentityCredential"), "disconnect", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "IdentityCredential"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Token
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "token");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsAutoSelected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isAutoSelected");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ConfigURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "configURL");
    }
}

#nullable disable