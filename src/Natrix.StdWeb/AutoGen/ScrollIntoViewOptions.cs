// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScrollIntoViewOptions: global::Natrix.StdWeb.ScrollOptions, global::Natrix.JSCore.IJSObjectProxy<ScrollIntoViewOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScrollIntoViewOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ScrollIntoViewOptions global::Natrix.JSCore.IJSObjectProxy<ScrollIntoViewOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScrollIntoViewOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollLogicalPosition Block
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollLogicalPosition>.Get(JSObject, "block");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollLogicalPosition>.Set(JSObject, "block", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollLogicalPosition Inline
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollLogicalPosition>.Get(JSObject, "inline");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollLogicalPosition>.Set(JSObject, "inline", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollIntoViewContainer Container
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollIntoViewContainer>.Get(JSObject, "container");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollIntoViewContainer>.Set(JSObject, "container", value);
    }
}

#nullable disable