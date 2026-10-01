// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CompositionEventInit: global::Natrix.StdWeb.UIEventInit, global::Natrix.JSCore.IJSObjectProxy<CompositionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CompositionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CompositionEventInit global::Natrix.JSCore.IJSObjectProxy<CompositionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CompositionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Data
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "data", value);
    }
}

#nullable disable