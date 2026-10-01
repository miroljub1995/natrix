// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OscillatorOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<OscillatorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OscillatorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OscillatorOptions global::Natrix.JSCore.IJSObjectProxy<OscillatorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OscillatorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OscillatorType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OscillatorType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OscillatorType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Frequency
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "frequency");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "frequency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Detune
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "detune");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "detune", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PeriodicWave PeriodicWave
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PeriodicWave>.Get(JSObject, "periodicWave");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PeriodicWave>.Set(JSObject, "periodicWave", value);
    }
}

#nullable disable