// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AbstractRange: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AbstractRange(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node StartContainer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "startContainer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StartOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "startOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node EndContainer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "endContainer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint EndOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "endOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Collapsed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "collapsed");
    }
}

#nullable disable