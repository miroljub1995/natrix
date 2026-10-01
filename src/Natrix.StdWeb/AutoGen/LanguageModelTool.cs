// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelTool: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelTool>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelTool(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelTool global::Natrix.JSCore.IJSObjectProxy<LanguageModelTool>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelTool(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Description
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "description");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "description", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::System.Runtime.InteropServices.JavaScript.JSObject InputSchema
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "inputSchema");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "inputSchema", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.LanguageModelToolFunction Execute
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolFunction>.Get(JSObject, "execute");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolFunction>.Set(JSObject, "execute", value);
    }
}

#nullable disable