// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OptionalEffectTiming: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<OptionalEffectTiming>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OptionalEffectTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OptionalEffectTiming global::Natrix.JSCore.IJSObjectProxy<OptionalEffectTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OptionalEffectTiming(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Delay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "delay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "delay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EndDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "endDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "endDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FillMode Fill
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillMode>.Get(JSObject, "fill");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillMode>.Set(JSObject, "fill", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double IterationStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "iterationStart");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "iterationStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Iterations
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "iterations");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "iterations", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, string, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.StringAccessor> Duration
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, string, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "duration");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, string, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "duration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PlaybackDirection Direction
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PlaybackDirection>.Get(JSObject, "direction");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PlaybackDirection>.Set(JSObject, "direction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Easing
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "easing");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "easing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PlaybackRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "playbackRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "playbackRate", value);
    }
}

#nullable disable