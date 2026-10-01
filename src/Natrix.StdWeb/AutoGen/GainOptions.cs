// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GainOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<GainOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GainOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GainOptions global::Natrix.JSCore.IJSObjectProxy<GainOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GainOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Gain
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "gain");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "gain", value);
    }
}

#nullable disable