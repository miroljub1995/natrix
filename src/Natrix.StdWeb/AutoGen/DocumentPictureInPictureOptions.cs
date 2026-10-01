// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DocumentPictureInPictureOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DocumentPictureInPictureOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentPictureInPictureOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DocumentPictureInPictureOptions global::Natrix.JSCore.IJSObjectProxy<DocumentPictureInPictureOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentPictureInPictureOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Width
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Height
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DisallowReturnToOpener
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disallowReturnToOpener");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disallowReturnToOpener", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreferInitialWindowPlacement
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preferInitialWindowPlacement");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preferInitialWindowPlacement", value);
    }
}

#nullable disable