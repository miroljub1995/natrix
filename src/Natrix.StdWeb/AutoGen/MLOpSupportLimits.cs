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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLInputOperandLayout, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>>(JSObject, "preferredInputLayout");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLInputOperandLayout, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLInputOperandLayout>>(JSObject, "preferredInputLayout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MaxTensorByteLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxTensorByteLength");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "maxTensorByteLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Input
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "input");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "input", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Constant
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "constant");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "constant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Output
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "output");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>>(JSObject, "output", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "argMin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "argMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ArgMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "argMax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "argMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBatchNormalizationSupportLimits BatchNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits>>(JSObject, "batchNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBatchNormalizationSupportLimits>>(JSObject, "batchNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cast");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Clamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "clamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "clamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConcatSupportLimits Concat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConcatSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConcatSupportLimits>>(JSObject, "concat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConcatSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConcatSupportLimits>>(JSObject, "concat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits Conv2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>>(JSObject, "conv2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>>(JSObject, "conv2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLConv2dSupportLimits ConvTranspose2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>>(JSObject, "convTranspose2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLConv2dSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLConv2dSupportLimits>>(JSObject, "convTranspose2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits CumulativeSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cumulativeSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cumulativeSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Add
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "add");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "add", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Sub
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "sub");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "sub", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Mul
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "mul");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "mul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Div
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "div");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "div", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Max
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "max");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Min
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "min");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Pow
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "pow");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "pow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Equal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "equal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "equal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits NotEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "notEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "notEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Greater
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "greater");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "greater", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits GreaterOrEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "greaterOrEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "greaterOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Lesser
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "lesser");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "lesser", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LesserOrEqual
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "lesserOrEqual");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "lesserOrEqual", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits LogicalNot
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "logicalNot");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "logicalNot", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalAnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalAnd");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalAnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalOr
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalOr");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalOr", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits LogicalXor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalXor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "logicalXor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsNaN
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "isNaN");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "isNaN", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLogicalNotSupportLimits IsInfinite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "isInfinite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLogicalNotSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLogicalNotSupportLimits>>(JSObject, "isInfinite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Abs
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "abs");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "abs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Ceil
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "ceil");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "ceil", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Cos
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cos");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "cos", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Erf
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "erf");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "erf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Exp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "exp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "exp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Floor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "floor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "floor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Identity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "identity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "identity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Log
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "log");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "log", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Neg
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "neg");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "neg", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reciprocal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reciprocal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reciprocal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits RoundEven
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "roundEven");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "roundEven", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sign
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sign");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sqrt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sqrt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sqrt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tan
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tan");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits DequantizeLinear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>>(JSObject, "dequantizeLinear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>>(JSObject, "dequantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits QuantizeLinear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>>(JSObject, "quantizeLinear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLQuantizeDequantizeLinearSupportLimits>>(JSObject, "quantizeLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Elu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "elu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "elu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Expand
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "expand");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "expand", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits Gather
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gather");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gather", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gatherElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gatherElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGatherSupportLimits GatherND
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gatherND");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGatherSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGatherSupportLimits>>(JSObject, "gatherND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Gelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "gelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "gelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGemmSupportLimits Gemm
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGemmSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGemmSupportLimits>>(JSObject, "gemm");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGemmSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGemmSupportLimits>>(JSObject, "gemm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruSupportLimits Gru
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGruSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruSupportLimits>>(JSObject, "gru");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGruSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruSupportLimits>>(JSObject, "gru", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruCellSupportLimits GruCell
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLGruCellSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruCellSupportLimits>>(JSObject, "gruCell");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLGruCellSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLGruCellSupportLimits>>(JSObject, "gruCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSigmoid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "hardSigmoid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "hardSigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits HardSwish
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "hardSwish");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "hardSwish", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits InstanceNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>>(JSObject, "instanceNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>>(JSObject, "instanceNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLNormalizationSupportLimits LayerNormalization
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>>(JSObject, "layerNormalization");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLNormalizationSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLNormalizationSupportLimits>>(JSObject, "layerNormalization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits LeakyRelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "leakyRelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "leakyRelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Linear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "linear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "linear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmSupportLimits Lstm
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLstmSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmSupportLimits>>(JSObject, "lstm");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLstmSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmSupportLimits>>(JSObject, "lstm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLLstmCellSupportLimits LstmCell
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLLstmCellSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmCellSupportLimits>>(JSObject, "lstmCell");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLLstmCellSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLLstmCellSupportLimits>>(JSObject, "lstmCell", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLBinarySupportLimits Matmul
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "matmul");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLBinarySupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLBinarySupportLimits>>(JSObject, "matmul", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Pad
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "pad");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "pad", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits AveragePool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "averagePool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "averagePool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits L2Pool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "l2Pool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "l2Pool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits MaxPool2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "maxPool2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "maxPool2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLPreluSupportLimits Prelu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLPreluSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLPreluSupportLimits>>(JSObject, "prelu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLPreluSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLPreluSupportLimits>>(JSObject, "prelu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceL1");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceL1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceL2
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceL2");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceL2", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceLogSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceLogSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceLogSumExp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceLogSumExp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceLogSumExp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMean
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMean");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMean", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceProduct
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceProduct");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceProduct", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits ReduceSumSquare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceSumSquare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reduceSumSquare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Relu
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "relu");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "relu", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Resample2d
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "resample2d");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "resample2d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reshape
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reshape");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reshape", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Reverse
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reverse");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "reverse", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>>(JSObject, "scatterElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>>(JSObject, "scatterElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLScatterSupportLimits ScatterND
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>>(JSObject, "scatterND");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLScatterSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLScatterSupportLimits>>(JSObject, "scatterND", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Sigmoid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sigmoid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "sigmoid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Slice
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "slice");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "slice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softmax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softmax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softmax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softplus
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softplus");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softplus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Softsign
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softsign");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "softsign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSplitSupportLimits Split
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSplitSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSplitSupportLimits>>(JSObject, "split");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSplitSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSplitSupportLimits>>(JSObject, "split", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tanh
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tanh");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tanh", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Tile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "tile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Transpose
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "transpose");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "transpose", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLSingleInputSupportLimits Triangular
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "triangular");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLSingleInputSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLSingleInputSupportLimits>>(JSObject, "triangular", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLWhereSupportLimits Where
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLWhereSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLWhereSupportLimits>>(JSObject, "where");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLWhereSupportLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLWhereSupportLimits>>(JSObject, "where", value);
    }
}

#nullable disable