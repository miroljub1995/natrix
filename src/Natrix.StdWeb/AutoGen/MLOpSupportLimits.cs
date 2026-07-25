// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLOpSupportLimits: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLOpSupportLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLOpSupportLimits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLInputOperandLayout PreferredInputLayout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLInputOperandLayout, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "preferredInputLayout");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLInputOperandLayout, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "preferredInputLayout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxTensorByteLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxTensorByteLength");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxTensorByteLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Input
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "input");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "input", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Constant
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "constant");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "constant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Output
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "output");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "output", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "argMin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "argMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "argMax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "argMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBatchNormalizationSupportLimits BatchNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "batchNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "batchNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cast");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Clamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConcatSupportLimits Concat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConcatSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "concat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConcatSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "concat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits Conv2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "conv2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "conv2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits ConvTranspose2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "convTranspose2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "convTranspose2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits CumulativeSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cumulativeSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cumulativeSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Add
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "add");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "add", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Sub
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sub");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sub", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Mul
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mul");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Div
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "div");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "div", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Max
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "max");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Min
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "min");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Pow
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pow");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Equal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "equal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "equal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits NotEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "notEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "notEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Greater
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "greater");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "greater", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits GreaterOrEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "greaterOrEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "greaterOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Lesser
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lesser");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lesser", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LesserOrEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lesserOrEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lesserOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits LogicalNot
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalNot");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalNot", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalAnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalAnd");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalAnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalOr
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalOr");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalOr", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalXor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalXor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalXor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsNaN
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isNaN");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isNaN", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsInfinite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isInfinite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isInfinite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Abs
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "abs");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "abs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Ceil
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ceil");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ceil", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cos
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cos");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cos", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Erf
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "erf");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "erf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Exp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Floor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "floor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "floor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Identity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "identity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "identity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Log
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "log");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "log", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Neg
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "neg");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "neg", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reciprocal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reciprocal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reciprocal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits RoundEven
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "roundEven");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "roundEven", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sign
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sign");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sqrt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sqrt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sqrt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tan
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tan");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits DequantizeLinear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "dequantizeLinear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "dequantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits QuantizeLinear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "quantizeLinear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "quantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Elu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "elu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "elu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Expand
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "expand");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "expand", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits Gather
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gather");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gather", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gatherElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gatherElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherND
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gatherND");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gatherND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Gelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGemmSupportLimits Gemm
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGemmSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gemm");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGemmSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gemm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruSupportLimits Gru
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGruSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gru");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGruSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gru", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruCellSupportLimits GruCell
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGruCellSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gruCell");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGruCellSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gruCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSigmoid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hardSigmoid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hardSigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSwish
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hardSwish");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hardSwish", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits InstanceNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "instanceNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "instanceNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits LayerNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layerNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layerNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits LeakyRelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "leakyRelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "leakyRelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Linear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "linear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "linear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmSupportLimits Lstm
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLstmSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lstm");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLstmSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lstm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmCellSupportLimits LstmCell
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLstmCellSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lstmCell");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLstmCellSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lstmCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Matmul
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "matmul");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "matmul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Pad
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pad");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pad", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits AveragePool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "averagePool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "averagePool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits L2Pool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "l2Pool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "l2Pool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits MaxPool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxPool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxPool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLPreluSupportLimits Prelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLPreluSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLPreluSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceL1");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceL1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL2
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceL2");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceL2", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceLogSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceLogSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSumExp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceLogSumExp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceLogSumExp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMean
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMean");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMean", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceProduct
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceProduct");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceProduct", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSumSquare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceSumSquare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reduceSumSquare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Relu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Resample2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resample2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resample2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reshape
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reshape");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reshape", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reverse
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reverse");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reverse", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scatterElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scatterElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterND
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scatterND");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scatterND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sigmoid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sigmoid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Slice
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "slice");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "slice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softmax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softmax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softmax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softplus
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softplus");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softplus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softsign
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softsign");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "softsign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSplitSupportLimits Split
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSplitSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "split");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSplitSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "split", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tanh
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tanh");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tanh", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Transpose
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transpose");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transpose", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Triangular
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "triangular");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "triangular", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLWhereSupportLimits Where
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLWhereSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "where");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLWhereSupportLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "where", value);
    }
}

#nullable disable