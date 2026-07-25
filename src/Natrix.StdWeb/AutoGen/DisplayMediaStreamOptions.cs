// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DisplayMediaStreamOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DisplayMediaStreamOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DisplayMediaStreamOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union> Video
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "video");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "video", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union> Audio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CaptureController Controller
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CaptureController, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "controller");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CaptureController, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "controller", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SelfCapturePreferenceEnum SelfBrowserSurface
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SelfCapturePreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selfBrowserSurface");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SelfCapturePreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selfBrowserSurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SystemAudioPreferenceEnum SystemAudio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SystemAudioPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "systemAudio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SystemAudioPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "systemAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WindowAudioPreferenceEnum WindowAudio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WindowAudioPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "windowAudio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WindowAudioPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "windowAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum SurfaceSwitching
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "surfaceSwitching");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SurfaceSwitchingPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "surfaceSwitching", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MonitorTypeSurfacesEnum MonitorTypeSurfaces
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MonitorTypeSurfacesEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "monitorTypeSurfaces");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MonitorTypeSurfacesEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "monitorTypeSurfaces", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSelectionPreferenceEnum AudioSelection
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSelectionPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audioSelection");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioSelectionPreferenceEnum, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audioSelection", value);
    }
}

#nullable disable