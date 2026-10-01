// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutConstraints: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LayoutConstraints>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutConstraints(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutConstraints global::Natrix.JSCore.IJSObjectProxy<LayoutConstraints>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutConstraints>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableInlineSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "availableInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableBlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "availableBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? FixedInlineSize
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "fixedInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? FixedBlockSize
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "fixedBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageInlineSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "percentageInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageBlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "percentageBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? BlockFragmentationOffset
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "blockFragmentationOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BlockFragmentationType BlockFragmentationType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BlockFragmentationType>.Get(JSObject, "blockFragmentationType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
    }
}

#nullable disable