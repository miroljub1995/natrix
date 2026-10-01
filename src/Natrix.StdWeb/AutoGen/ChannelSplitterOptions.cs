// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChannelSplitterOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<ChannelSplitterOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChannelSplitterOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ChannelSplitterOptions global::Natrix.JSCore.IJSObjectProxy<ChannelSplitterOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChannelSplitterOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NumberOfOutputs
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "numberOfOutputs");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "numberOfOutputs", value);
    }
}

#nullable disable