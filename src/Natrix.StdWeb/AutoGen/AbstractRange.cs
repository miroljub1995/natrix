// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AbstractRange: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AbstractRange>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AbstractRange(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AbstractRange global::Natrix.JSCore.IJSObjectProxy<AbstractRange>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AbstractRange>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node StartContainer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "startContainer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StartOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "startOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node EndContainer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "endContainer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint EndOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "endOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Collapsed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "collapsed");
    }
}

#nullable disable