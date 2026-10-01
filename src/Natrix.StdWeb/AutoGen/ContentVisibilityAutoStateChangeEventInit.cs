// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ContentVisibilityAutoStateChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<ContentVisibilityAutoStateChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContentVisibilityAutoStateChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ContentVisibilityAutoStateChangeEventInit global::Natrix.JSCore.IJSObjectProxy<ContentVisibilityAutoStateChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContentVisibilityAutoStateChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Skipped
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "skipped");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "skipped", value);
    }
}

#nullable disable