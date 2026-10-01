// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DigitalCredentialCreationOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DigitalCredentialCreationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalCredentialCreationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DigitalCredentialCreationOptions global::Natrix.JSCore.IJSObjectProxy<DigitalCredentialCreationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalCredentialCreationOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialCreateRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialCreateRequest>> Requests
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialCreateRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialCreateRequest>>>.Get(JSObject, "requests");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DigitalCredentialCreateRequest, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialCreateRequest>>>.Set(JSObject, "requests", value);
    }
}

#nullable disable