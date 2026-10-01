// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutFragment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LayoutFragment>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutFragment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutFragment global::Natrix.JSCore.IJSObjectProxy<LayoutFragment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutFragment>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "inlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "blockSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineOffset
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "inlineOffset");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "inlineOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockOffset
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "blockOffset");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "blockOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ChildBreakToken? BreakToken
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ChildBreakToken>.Get(JSObject, "breakToken");
    }
}

#nullable disable