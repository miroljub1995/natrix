// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ToggleEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<ToggleEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToggleEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ToggleEventInit global::Natrix.JSCore.IJSObjectProxy<ToggleEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToggleEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OldState
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "oldState");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "oldState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NewState
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "newState");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "newState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? Source
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "source");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "source", value);
    }
}

#nullable disable