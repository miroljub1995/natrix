// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SerialOutputSignals: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SerialOutputSignals>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialOutputSignals(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SerialOutputSignals global::Natrix.JSCore.IJSObjectProxy<SerialOutputSignals>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialOutputSignals(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DataTerminalReady
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "dataTerminalReady");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "dataTerminalReady", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequestToSend
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requestToSend");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requestToSend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Break
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "break");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "break", value);
    }
}

#nullable disable