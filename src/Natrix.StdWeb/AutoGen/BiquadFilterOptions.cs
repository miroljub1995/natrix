// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BiquadFilterOptions: global::Natrix.StdWeb.AudioNodeOptions
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BiquadFilterOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BiquadFilterOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BiquadFilterType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BiquadFilterType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BiquadFilterType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Q
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "Q");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "Q", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Detune
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "detune");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "detune", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Frequency
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "frequency");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "frequency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Gain
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gain");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gain", value);
    }
}

#nullable disable