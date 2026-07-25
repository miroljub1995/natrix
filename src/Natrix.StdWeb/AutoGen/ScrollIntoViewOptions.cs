// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScrollIntoViewOptions: global::Natrix.StdWeb.ScrollOptions
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScrollIntoViewOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScrollIntoViewOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollLogicalPosition Block
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScrollLogicalPosition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "block");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ScrollLogicalPosition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "block", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollLogicalPosition Inline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScrollLogicalPosition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inline");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ScrollLogicalPosition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inline", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollIntoViewContainer Container
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScrollIntoViewContainer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "container");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ScrollIntoViewContainer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "container", value);
    }
}

#nullable disable