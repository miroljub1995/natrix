// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLOpSupportLimits: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLOpSupportLimits>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLOpSupportLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLOpSupportLimits global::Natrix.JSCore.IJSObjectProxy<MLOpSupportLimits>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLOpSupportLimits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLInputOperandLayout PreferredInputLayout
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>.Get(JSObject, "preferredInputLayout");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>.Set(JSObject, "preferredInputLayout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxTensorByteLength
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "maxTensorByteLength");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "maxTensorByteLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Input
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Get(JSObject, "input");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Set(JSObject, "input", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Constant
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Get(JSObject, "constant");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Set(JSObject, "constant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Output
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Get(JSObject, "output");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Set(JSObject, "output", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMin
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "argMin");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "argMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMax
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "argMax");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "argMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBatchNormalizationSupportLimits BatchNormalization
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits>.Get(JSObject, "batchNormalization");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits>.Set(JSObject, "batchNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cast
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "cast");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "cast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Clamp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "clamp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "clamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConcatSupportLimits Concat
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConcatSupportLimits>.Get(JSObject, "concat");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConcatSupportLimits>.Set(JSObject, "concat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits Conv2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>.Get(JSObject, "conv2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>.Set(JSObject, "conv2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits ConvTranspose2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>.Get(JSObject, "convTranspose2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>.Set(JSObject, "convTranspose2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits CumulativeSum
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "cumulativeSum");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "cumulativeSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Add
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "add");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "add", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Sub
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "sub");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "sub", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Mul
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "mul");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "mul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Div
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "div");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "div", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Max
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "max");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Min
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "min");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Pow
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "pow");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "pow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Equal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "equal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "equal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits NotEqual
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "notEqual");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "notEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Greater
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "greater");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "greater", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits GreaterOrEqual
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "greaterOrEqual");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "greaterOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Lesser
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "lesser");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "lesser", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LesserOrEqual
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "lesserOrEqual");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "lesserOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits LogicalNot
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Get(JSObject, "logicalNot");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Set(JSObject, "logicalNot", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalAnd
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "logicalAnd");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "logicalAnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalOr
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "logicalOr");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "logicalOr", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalXor
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "logicalXor");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "logicalXor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsNaN
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Get(JSObject, "isNaN");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Set(JSObject, "isNaN", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsInfinite
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Get(JSObject, "isInfinite");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>.Set(JSObject, "isInfinite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Abs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "abs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "abs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Ceil
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "ceil");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "ceil", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cos
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "cos");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "cos", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Erf
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "erf");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "erf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Exp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "exp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "exp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Floor
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "floor");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "floor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Identity
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "identity");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "identity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Log
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "log");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "log", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Neg
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "neg");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "neg", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reciprocal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reciprocal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reciprocal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits RoundEven
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "roundEven");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "roundEven", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sin
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "sin");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "sin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sign
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "sign");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "sign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sqrt
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "sqrt");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "sqrt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tan
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "tan");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "tan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits DequantizeLinear
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>.Get(JSObject, "dequantizeLinear");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>.Set(JSObject, "dequantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits QuantizeLinear
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>.Get(JSObject, "quantizeLinear");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>.Set(JSObject, "quantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Elu
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "elu");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "elu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Expand
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "expand");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "expand", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits Gather
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Get(JSObject, "gather");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Set(JSObject, "gather", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherElements
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Get(JSObject, "gatherElements");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Set(JSObject, "gatherElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherND
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Get(JSObject, "gatherND");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>.Set(JSObject, "gatherND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Gelu
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "gelu");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "gelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGemmSupportLimits Gemm
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGemmSupportLimits>.Get(JSObject, "gemm");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGemmSupportLimits>.Set(JSObject, "gemm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruSupportLimits Gru
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruSupportLimits>.Get(JSObject, "gru");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruSupportLimits>.Set(JSObject, "gru", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruCellSupportLimits GruCell
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruCellSupportLimits>.Get(JSObject, "gruCell");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruCellSupportLimits>.Set(JSObject, "gruCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSigmoid
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "hardSigmoid");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "hardSigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSwish
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "hardSwish");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "hardSwish", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits InstanceNormalization
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>.Get(JSObject, "instanceNormalization");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>.Set(JSObject, "instanceNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits LayerNormalization
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>.Get(JSObject, "layerNormalization");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>.Set(JSObject, "layerNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits LeakyRelu
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "leakyRelu");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "leakyRelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Linear
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "linear");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "linear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmSupportLimits Lstm
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmSupportLimits>.Get(JSObject, "lstm");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmSupportLimits>.Set(JSObject, "lstm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmCellSupportLimits LstmCell
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmCellSupportLimits>.Get(JSObject, "lstmCell");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmCellSupportLimits>.Set(JSObject, "lstmCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Matmul
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Get(JSObject, "matmul");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>.Set(JSObject, "matmul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Pad
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "pad");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "pad", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits AveragePool2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "averagePool2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "averagePool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits L2Pool2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "l2Pool2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "l2Pool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits MaxPool2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "maxPool2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "maxPool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLPreluSupportLimits Prelu
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLPreluSupportLimits>.Get(JSObject, "prelu");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLPreluSupportLimits>.Set(JSObject, "prelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL1
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceL1");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceL1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL2
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceL2");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceL2", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSum
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceLogSum");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceLogSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSumExp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceLogSumExp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceLogSumExp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMax
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceMax");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMean
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceMean");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceMean", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMin
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceMin");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceProduct
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceProduct");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceProduct", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSum
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceSum");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSumSquare
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reduceSumSquare");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reduceSumSquare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Relu
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "relu");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "relu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Resample2d
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "resample2d");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "resample2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reshape
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reshape");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reshape", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reverse
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "reverse");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "reverse", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterElements
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>.Get(JSObject, "scatterElements");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>.Set(JSObject, "scatterElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterND
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>.Get(JSObject, "scatterND");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>.Set(JSObject, "scatterND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sigmoid
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "sigmoid");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "sigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Slice
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "slice");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "slice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softmax
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "softmax");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "softmax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softplus
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "softplus");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "softplus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softsign
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "softsign");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "softsign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSplitSupportLimits Split
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSplitSupportLimits>.Get(JSObject, "split");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSplitSupportLimits>.Set(JSObject, "split", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tanh
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "tanh");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "tanh", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tile
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "tile");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "tile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Transpose
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "transpose");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "transpose", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Triangular
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Get(JSObject, "triangular");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>.Set(JSObject, "triangular", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLWhereSupportLimits Where
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLWhereSupportLimits>.Get(JSObject, "where");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLWhereSupportLimits>.Set(JSObject, "where", value);
    }
}

#nullable disable