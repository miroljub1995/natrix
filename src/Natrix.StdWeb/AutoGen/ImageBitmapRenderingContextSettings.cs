// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageBitmapRenderingContextSettings: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageBitmapRenderingContextSettings>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapRenderingContextSettings(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageBitmapRenderingContextSettings global::Natrix.JSCore.IJSObjectProxy<ImageBitmapRenderingContextSettings>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapRenderingContextSettings(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alpha", value);
    }
}

#nullable disable