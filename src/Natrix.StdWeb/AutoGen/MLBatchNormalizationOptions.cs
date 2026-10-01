// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLBatchNormalizationOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLBatchNormalizationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLBatchNormalizationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLBatchNormalizationOptions global::Natrix.JSCore.IJSObjectProxy<MLBatchNormalizationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLBatchNormalizationOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperand Scale
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Get(JSObject, "scale");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Set(JSObject, "scale", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperand Bias
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Get(JSObject, "bias");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Set(JSObject, "bias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Axis
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "axis");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "axis", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Epsilon
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "epsilon");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "epsilon", value);
    }
}

#nullable disable