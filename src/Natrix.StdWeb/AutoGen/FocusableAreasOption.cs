// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FocusableAreasOption: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FocusableAreasOption>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FocusableAreasOption(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FocusableAreasOption global::Natrix.JSCore.IJSObjectProxy<FocusableAreasOption>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FocusableAreasOption(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FocusableAreaSearchMode Mode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FocusableAreaSearchMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FocusableAreaSearchMode>>(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FocusableAreaSearchMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FocusableAreaSearchMode>>(JSObject, "mode", value);
    }
}

#nullable disable