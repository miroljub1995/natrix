// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PresentationConnectionAvailableEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionAvailableEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationConnectionAvailableEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PresentationConnectionAvailableEventInit global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionAvailableEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationConnectionAvailableEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PresentationConnection Connection
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnection>.Get(JSObject, "connection");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnection>.Set(JSObject, "connection", value);
    }
}

#nullable disable