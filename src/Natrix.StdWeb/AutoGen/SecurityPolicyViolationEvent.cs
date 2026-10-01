// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SecurityPolicyViolationEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<SecurityPolicyViolationEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SecurityPolicyViolationEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SecurityPolicyViolationEvent global::Natrix.JSCore.IJSObjectProxy<SecurityPolicyViolationEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SecurityPolicyViolationEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SecurityPolicyViolationEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SecurityPolicyViolationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SecurityPolicyViolationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SecurityPolicyViolationEvent New(string type, global::Natrix.StdWeb.SecurityPolicyViolationEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SecurityPolicyViolationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SecurityPolicyViolationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentURI
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "documentURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Referrer
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BlockedURI
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "blockedURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EffectiveDirective
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "effectiveDirective");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ViolatedDirective
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "violatedDirective");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OriginalPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "originalPolicy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceFile
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sourceFile");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Sample
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sample");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition Disposition
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition>.Get(JSObject, "disposition");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort StatusCode
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "statusCode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint LineNumber
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lineNumber");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "columnNumber");
    }
}

#nullable disable