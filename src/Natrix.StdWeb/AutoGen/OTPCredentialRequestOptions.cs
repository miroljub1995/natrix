// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OTPCredentialRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<OTPCredentialRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OTPCredentialRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OTPCredentialRequestOptions global::Natrix.JSCore.IJSObjectProxy<OTPCredentialRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OTPCredentialRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.OTPCredentialTransportType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OTPCredentialTransportType>> Transport
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.OTPCredentialTransportType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OTPCredentialTransportType>>>.Get(JSObject, "transport");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.OTPCredentialTransportType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OTPCredentialTransportType>>>.Set(JSObject, "transport", value);
    }
}

#nullable disable