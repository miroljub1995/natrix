// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutEdges: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LayoutEdges>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutEdges(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutEdges global::Natrix.JSCore.IJSObjectProxy<LayoutEdges>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutEdges>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "inlineStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "inlineEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "blockStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "blockEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Inline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "inline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Block
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "block");
    }
}

#nullable disable