// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DragEventInit: global::Natrix.StdWeb.MouseEventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DragEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DragEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DataTransfer? DataTransfer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DataTransfer?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "dataTransfer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DataTransfer?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "dataTransfer", value);
    }
}

#nullable disable