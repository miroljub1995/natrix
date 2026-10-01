// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BasePropertyIndexedKeyframe: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BasePropertyIndexedKeyframe>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BasePropertyIndexedKeyframe(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BasePropertyIndexedKeyframe global::Natrix.JSCore.IJSObjectProxy<BasePropertyIndexedKeyframe>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BasePropertyIndexedKeyframe(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>>>? Offset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>>>>>(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>>>>>(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>> Easing
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>>(JSObject, "easing");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>>(JSObject, "easing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>>> Composite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>>>>>(JSObject, "composite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>>>>>>(JSObject, "composite", value);
    }
}

#nullable disable