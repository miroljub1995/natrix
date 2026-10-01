// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLInstanceNormalizationOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLInstanceNormalizationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLInstanceNormalizationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLInstanceNormalizationOptions global::Natrix.JSCore.IJSObjectProxy<MLInstanceNormalizationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLInstanceNormalizationOptions(): base()
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
    public double Epsilon
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "epsilon");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "epsilon", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLInputOperandLayout Layout
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>.Set(JSObject, "layout", value);
    }
}

#nullable disable