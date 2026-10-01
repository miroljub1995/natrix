// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FragmentResultOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FragmentResultOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FragmentResultOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FragmentResultOptions global::Natrix.JSCore.IJSObjectProxy<FragmentResultOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FragmentResultOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "inlineSize");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "inlineSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "blockSize");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "blockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AutoBlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "autoBlockSize");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "autoBlockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>> ChildFragments
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>>>.Get(JSObject, "childFragments");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>>>.Set(JSObject, "childFragments", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BreakTokenOptions BreakToken
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BreakTokenOptions>.Get(JSObject, "breakToken");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BreakTokenOptions>.Set(JSObject, "breakToken", value);
    }
}

#nullable disable