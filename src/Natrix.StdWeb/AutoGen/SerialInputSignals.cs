// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SerialInputSignals: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SerialInputSignals>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialInputSignals(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SerialInputSignals global::Natrix.JSCore.IJSObjectProxy<SerialInputSignals>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialInputSignals(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool DataCarrierDetect
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "dataCarrierDetect");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "dataCarrierDetect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool ClearToSend
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "clearToSend");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "clearToSend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool RingIndicator
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ringIndicator");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ringIndicator", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool DataSetReady
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "dataSetReady");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "dataSetReady", value);
    }
}

#nullable disable