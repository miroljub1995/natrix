// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpHeaderExtensionParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCRtpHeaderExtensionParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpHeaderExtensionParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpHeaderExtensionParameters global::Natrix.JSCore.IJSObjectProxy<RTCRtpHeaderExtensionParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpHeaderExtensionParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Uri
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "uri");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "uri", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort Id
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Encrypted
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "encrypted");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "encrypted", value);
    }
}

#nullable disable