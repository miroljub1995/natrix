// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutConstraintsOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutConstraintsOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutConstraintsOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableInlineSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableInlineSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableBlockSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availableBlockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FixedInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fixedInlineSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fixedInlineSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FixedBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fixedBlockSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fixedBlockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageInlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageInlineSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageInlineSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PercentageBlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageBlockSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "percentageBlockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockFragmentationOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockFragmentationOffset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockFragmentationOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BlockFragmentationType BlockFragmentationType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BlockFragmentationType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockFragmentationType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BlockFragmentationType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockFragmentationType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? Data
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "data");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "data", value);
    }
}

#nullable disable