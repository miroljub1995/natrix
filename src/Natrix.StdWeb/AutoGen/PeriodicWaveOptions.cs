// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PeriodicWaveOptions: global::Natrix.StdWeb.PeriodicWaveConstraints, global::Natrix.JSCore.IJSObjectProxy<PeriodicWaveOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PeriodicWaveOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PeriodicWaveOptions global::Natrix.JSCore.IJSObjectProxy<PeriodicWaveOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PeriodicWaveOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor> Real
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Get(JSObject, "real");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Set(JSObject, "real", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor> Imag
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Get(JSObject, "imag");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>.Set(JSObject, "imag", value);
    }
}

#nullable disable