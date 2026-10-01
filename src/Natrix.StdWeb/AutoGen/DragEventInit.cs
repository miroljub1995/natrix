// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DragEventInit: global::Natrix.StdWeb.MouseEventInit, global::Natrix.JSCore.IJSObjectProxy<DragEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DragEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DragEventInit global::Natrix.JSCore.IJSObjectProxy<DragEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DragEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DataTransfer? DataTransfer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DataTransfer>.Get(JSObject, "dataTransfer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DataTransfer>.Set(JSObject, "dataTransfer", value);
    }
}

#nullable disable