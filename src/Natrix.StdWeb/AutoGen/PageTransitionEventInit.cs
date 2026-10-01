// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PageTransitionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<PageTransitionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PageTransitionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PageTransitionEventInit global::Natrix.JSCore.IJSObjectProxy<PageTransitionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PageTransitionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Persisted
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "persisted");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "persisted", value);
    }
}

#nullable disable