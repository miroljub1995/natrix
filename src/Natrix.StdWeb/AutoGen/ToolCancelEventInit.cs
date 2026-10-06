// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ToolCancelEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<ToolCancelEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToolCancelEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ToolCancelEventInit global::Natrix.JSCore.IJSObjectProxy<ToolCancelEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToolCancelEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ToolName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "toolName");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "toolName", value);
    }
}

#nullable disable