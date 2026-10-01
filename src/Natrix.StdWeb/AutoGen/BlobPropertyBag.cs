// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BlobPropertyBag: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BlobPropertyBag>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BlobPropertyBag(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BlobPropertyBag global::Natrix.JSCore.IJSObjectProxy<BlobPropertyBag>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BlobPropertyBag(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EndingType Endings
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.EndingType>.Get(JSObject, "endings");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.EndingType>.Set(JSObject, "endings", value);
    }
}

#nullable disable