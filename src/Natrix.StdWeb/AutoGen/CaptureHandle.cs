// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CaptureHandle: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CaptureHandle>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CaptureHandle(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CaptureHandle global::Natrix.JSCore.IJSObjectProxy<CaptureHandle>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CaptureHandle(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Handle
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "handle");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "handle", value);
    }
}

#nullable disable