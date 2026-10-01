// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChannelMergerOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<ChannelMergerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChannelMergerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ChannelMergerOptions global::Natrix.JSCore.IJSObjectProxy<ChannelMergerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChannelMergerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NumberOfInputs
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "numberOfInputs");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "numberOfInputs", value);
    }
}

#nullable disable