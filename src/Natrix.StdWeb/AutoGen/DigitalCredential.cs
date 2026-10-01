// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DigitalCredential: global::Natrix.StdWeb.Credential, global::Natrix.JSCore.IJSObjectProxy<DigitalCredential>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalCredential(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DigitalCredential global::Natrix.JSCore.IJSObjectProxy<DigitalCredential>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DigitalCredential>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol, global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol>> Protocol
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol, global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol>>>.Get(JSObject, "protocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Data
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static bool UserAgentAllowsProtocol(string protocol)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = protocol;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DigitalCredential"), "userAgentAllowsProtocol", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DigitalCredential"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable