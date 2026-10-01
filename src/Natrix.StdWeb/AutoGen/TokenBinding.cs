// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TokenBinding: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TokenBinding>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TokenBinding(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TokenBinding global::Natrix.JSCore.IJSObjectProxy<TokenBinding>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TokenBinding(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Status
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "status");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "status", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }
}

#nullable disable