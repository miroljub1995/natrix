// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIdentityValidationResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIdentityValidationResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityValidationResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIdentityValidationResult global::Natrix.JSCore.IJSObjectProxy<RTCIdentityValidationResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityValidationResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Identity
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "identity");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "identity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Contents
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contents");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "contents", value);
    }
}

#nullable disable