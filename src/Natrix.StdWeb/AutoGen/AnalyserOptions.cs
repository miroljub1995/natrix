// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnalyserOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<AnalyserOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnalyserOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AnalyserOptions global::Natrix.JSCore.IJSObjectProxy<AnalyserOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnalyserOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FftSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "fftSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "fftSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxDecibels
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxDecibels");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "maxDecibels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinDecibels
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minDecibels");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "minDecibels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SmoothingTimeConstant
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "smoothingTimeConstant");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "smoothingTimeConstant", value);
    }
}

#nullable disable