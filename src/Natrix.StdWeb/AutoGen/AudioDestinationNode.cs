// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioDestinationNode: global::Natrix.StdWeb.AudioNode
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDestinationNode(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxChannelCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxChannelCount");
    }
}

#nullable disable