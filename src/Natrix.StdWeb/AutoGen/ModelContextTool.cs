// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ModelContextTool: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ModelContextTool>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ModelContextTool(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ModelContextTool global::Natrix.JSCore.IJSObjectProxy<ModelContextTool>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ModelContextTool(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Title
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "title");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "title", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Description
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "description");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "description", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject InputSchema
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "inputSchema");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "inputSchema", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.ToolExecuteCallback Execute
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ToolExecuteCallback>.Get(JSObject, "execute");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ToolExecuteCallback>.Set(JSObject, "execute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ToolAnnotations Annotations
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ToolAnnotations>.Get(JSObject, "annotations");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ToolAnnotations>.Set(JSObject, "annotations", value);
    }
}

#nullable disable