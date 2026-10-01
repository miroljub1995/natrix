// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScriptProcessorNode: global::Natrix.StdWeb.AudioNode, global::Natrix.JSCore.IJSObjectProxy<ScriptProcessorNode>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScriptProcessorNode(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ScriptProcessorNode global::Natrix.JSCore.IJSObjectProxy<ScriptProcessorNode>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ScriptProcessorNode>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onaudioprocess
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onaudioprocess");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onaudioprocess", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int BufferSize
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "bufferSize");
    }
}

#nullable disable