// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelToolSuccess: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolSuccess>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolSuccess(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelToolSuccess global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolSuccess>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LanguageModelToolSuccess>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.LanguageModelToolSuccess New(global::Natrix.StdWeb.LanguageModelToolSuccessInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "LanguageModelToolSuccess", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.LanguageModelToolSuccess(___res_2);
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
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.LanguageModelToolResultContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolResultContent>> Result
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.LanguageModelToolResultContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolResultContent>>>.Get(JSObject, "result");
    }
}

#nullable disable