// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DisplayMediaStreamOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DisplayMediaStreamOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DisplayMediaStreamOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DisplayMediaStreamOptions global::Natrix.JSCore.IJSObjectProxy<DisplayMediaStreamOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DisplayMediaStreamOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>> Video
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>>(JSObject, "video");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>>(JSObject, "video", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>> Audio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>>(JSObject, "audio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>>(JSObject, "audio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CaptureController Controller
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CaptureController, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CaptureController>>(JSObject, "controller");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CaptureController, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CaptureController>>(JSObject, "controller", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SelfCapturePreferenceEnum SelfBrowserSurface
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SelfCapturePreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SelfCapturePreferenceEnum>>(JSObject, "selfBrowserSurface");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SelfCapturePreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SelfCapturePreferenceEnum>>(JSObject, "selfBrowserSurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SystemAudioPreferenceEnum SystemAudio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SystemAudioPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SystemAudioPreferenceEnum>>(JSObject, "systemAudio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SystemAudioPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SystemAudioPreferenceEnum>>(JSObject, "systemAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WindowAudioPreferenceEnum WindowAudio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WindowAudioPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WindowAudioPreferenceEnum>>(JSObject, "windowAudio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WindowAudioPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WindowAudioPreferenceEnum>>(JSObject, "windowAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum SurfaceSwitching
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum>>(JSObject, "surfaceSwitching");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum>>(JSObject, "surfaceSwitching", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MonitorTypeSurfacesEnum MonitorTypeSurfaces
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MonitorTypeSurfacesEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MonitorTypeSurfacesEnum>>(JSObject, "monitorTypeSurfaces");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MonitorTypeSurfacesEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MonitorTypeSurfacesEnum>>(JSObject, "monitorTypeSurfaces", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSelectionPreferenceEnum AudioSelection
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSelectionPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSelectionPreferenceEnum>>(JSObject, "audioSelection");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioSelectionPreferenceEnum, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSelectionPreferenceEnum>>(JSObject, "audioSelection", value);
    }
}

#nullable disable