// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Font: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Font>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Font(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Font global::Natrix.JSCore.IJSObjectProxy<Font>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Font>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint GlyphsRendered
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "glyphsRendered");
    }
}

#nullable disable