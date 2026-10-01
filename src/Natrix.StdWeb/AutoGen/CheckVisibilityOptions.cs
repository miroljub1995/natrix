// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CheckVisibilityOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CheckVisibilityOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CheckVisibilityOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CheckVisibilityOptions global::Natrix.JSCore.IJSObjectProxy<CheckVisibilityOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CheckVisibilityOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckOpacity
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "checkOpacity");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "checkOpacity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckVisibilityCSS
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "checkVisibilityCSS");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "checkVisibilityCSS", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ContentVisibilityAuto
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "contentVisibilityAuto");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "contentVisibilityAuto", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool OpacityProperty
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "opacityProperty");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "opacityProperty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool VisibilityProperty
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "visibilityProperty");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "visibilityProperty", value);
    }
}

#nullable disable