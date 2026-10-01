// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaPositionState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaPositionState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaPositionState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaPositionState global::Natrix.JSCore.IJSObjectProxy<MediaPositionState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaPositionState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Duration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "duration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "duration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PlaybackRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "playbackRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "playbackRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Position
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "position");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "position", value);
    }
}

#nullable disable