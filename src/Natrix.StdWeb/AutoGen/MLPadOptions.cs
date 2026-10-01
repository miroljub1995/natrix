// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLPadOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLPadOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLPadOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLPadOptions global::Natrix.JSCore.IJSObjectProxy<MLPadOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLPadOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLPaddingMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLPaddingMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLPaddingMode>.Set(JSObject, "mode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor> Value
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "value", value);
    }
}

#nullable disable