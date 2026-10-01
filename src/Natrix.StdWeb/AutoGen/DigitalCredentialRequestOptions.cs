// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DigitalCredentialRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DigitalCredentialRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalCredentialRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DigitalCredentialRequestOptions global::Natrix.JSCore.IJSObjectProxy<DigitalCredentialRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalCredentialRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialGetRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialGetRequest>> Requests
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialGetRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialGetRequest>>>.Get(JSObject, "requests");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialGetRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialGetRequest>>>.Set(JSObject, "requests", value);
    }
}

#nullable disable