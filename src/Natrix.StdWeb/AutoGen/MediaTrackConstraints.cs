// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaTrackConstraints: global::Natrix.StdWeb.MediaTrackConstraintSet, global::Natrix.JSCore.IJSObjectProxy<MediaTrackConstraints>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackConstraints(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaTrackConstraints global::Natrix.JSCore.IJSObjectProxy<MediaTrackConstraints>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackConstraints(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaTrackConstraintSet, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraintSet>> Advanced
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaTrackConstraintSet, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraintSet>>>.Get(JSObject, "advanced");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaTrackConstraintSet, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraintSet>>>.Set(JSObject, "advanced", value);
    }
}

#nullable disable