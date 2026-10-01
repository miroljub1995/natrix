// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StereoPannerOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<StereoPannerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StereoPannerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StereoPannerOptions global::Natrix.JSCore.IJSObjectProxy<StereoPannerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StereoPannerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Pan
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "pan");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "pan", value);
    }
}

#nullable disable