// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCAudioSourceStats: global::Natrix.StdWeb.RTCMediaSourceStats, global::Natrix.JSCore.IJSObjectProxy<RTCAudioSourceStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAudioSourceStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCAudioSourceStats global::Natrix.JSCore.IJSObjectProxy<RTCAudioSourceStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAudioSourceStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AudioLevel
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "audioLevel");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "audioLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalAudioEnergy
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalAudioEnergy");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalAudioEnergy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalSamplesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalSamplesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalSamplesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EchoReturnLoss
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "echoReturnLoss");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "echoReturnLoss", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EchoReturnLossEnhancement
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "echoReturnLossEnhancement");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "echoReturnLossEnhancement", value);
    }
}

#nullable disable