// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PhotoCapabilities: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PhotoCapabilities>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PhotoCapabilities(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PhotoCapabilities global::Natrix.JSCore.IJSObjectProxy<PhotoCapabilities>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PhotoCapabilities(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RedEyeReduction RedEyeReduction
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RedEyeReduction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RedEyeReduction>>(JSObject, "redEyeReduction");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RedEyeReduction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RedEyeReduction>>(JSObject, "redEyeReduction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ImageHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "imageHeight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "imageHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ImageWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "imageWidth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "imageWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>> FillLightMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>>>(JSObject, "fillLightMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>>>(JSObject, "fillLightMode", value);
    }
}

#nullable disable