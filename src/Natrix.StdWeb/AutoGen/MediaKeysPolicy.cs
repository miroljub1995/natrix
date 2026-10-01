// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaKeysPolicy: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaKeysPolicy>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeysPolicy(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaKeysPolicy global::Natrix.JSCore.IJSObjectProxy<MediaKeysPolicy>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeysPolicy(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MinHdcpVersion
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "minHdcpVersion");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "minHdcpVersion", value);
    }
}

#nullable disable