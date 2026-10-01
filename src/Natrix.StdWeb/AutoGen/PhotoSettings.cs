// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PhotoSettings: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PhotoSettings>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PhotoSettings(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PhotoSettings global::Natrix.JSCore.IJSObjectProxy<PhotoSettings>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PhotoSettings(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FillLightMode FillLightMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>(JSObject, "fillLightMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FillLightMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FillLightMode>>(JSObject, "fillLightMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ImageHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "imageHeight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "imageHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ImageWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "imageWidth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "imageWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RedEyeReduction
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "redEyeReduction");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "redEyeReduction", value);
    }
}

#nullable disable