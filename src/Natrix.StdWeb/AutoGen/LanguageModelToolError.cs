// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelToolError: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolError>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelToolError global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolError>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LanguageModelToolError>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.LanguageModelToolError New(global::Natrix.StdWeb.LanguageModelToolErrorInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "LanguageModelToolError", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.LanguageModelToolError(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CallId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "callId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ErrorMessage
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "errorMessage");
    }
}

#nullable disable