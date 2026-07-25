// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FocusEventInit: global::Natrix.StdWeb.UIEventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FocusEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FocusEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget? RelatedTarget
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventTarget?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "relatedTarget");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventTarget?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "relatedTarget", value);
    }
}

#nullable disable