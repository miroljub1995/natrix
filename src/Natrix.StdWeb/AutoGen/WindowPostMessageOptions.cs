// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WindowPostMessageOptions: global::Natrix.StdWeb.StructuredSerializeOptions, global::Natrix.JSCore.IJSObjectProxy<WindowPostMessageOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowPostMessageOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WindowPostMessageOptions global::Natrix.JSCore.IJSObjectProxy<WindowPostMessageOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowPostMessageOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TargetOrigin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "targetOrigin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "targetOrigin", value);
    }
}

#nullable disable