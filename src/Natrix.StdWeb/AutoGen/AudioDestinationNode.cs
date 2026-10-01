// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioDestinationNode: global::Natrix.StdWeb.AudioNode, global::Natrix.JSCore.IJSObjectProxy<AudioDestinationNode>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDestinationNode(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioDestinationNode global::Natrix.JSCore.IJSObjectProxy<AudioDestinationNode>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioDestinationNode>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxChannelCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxChannelCount");
    }
}

#nullable disable