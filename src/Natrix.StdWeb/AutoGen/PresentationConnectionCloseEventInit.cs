// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PresentationConnectionCloseEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionCloseEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationConnectionCloseEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PresentationConnectionCloseEventInit global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionCloseEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationConnectionCloseEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PresentationConnectionCloseReason Reason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PresentationConnectionCloseReason>.Get(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PresentationConnectionCloseReason>.Set(JSObject, "reason", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "message", value);
    }
}

#nullable disable