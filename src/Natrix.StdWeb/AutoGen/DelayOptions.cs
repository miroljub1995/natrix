// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DelayOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<DelayOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DelayOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DelayOptions global::Natrix.JSCore.IJSObjectProxy<DelayOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DelayOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxDelayTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxDelayTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "maxDelayTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DelayTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "delayTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "delayTime", value);
    }
}

#nullable disable