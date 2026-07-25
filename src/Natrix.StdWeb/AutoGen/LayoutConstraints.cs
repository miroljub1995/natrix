// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutConstraints: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutConstraints(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? FixedInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? FixedBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageInlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageBlockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? BlockFragmentationOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "blockFragmentationOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BlockFragmentationType BlockFragmentationType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BlockFragmentationType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockFragmentationType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? Data
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "data");
    }
}

#nullable disable