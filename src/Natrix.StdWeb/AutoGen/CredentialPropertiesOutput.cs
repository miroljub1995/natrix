// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CredentialPropertiesOutput: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CredentialPropertiesOutput>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialPropertiesOutput(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CredentialPropertiesOutput global::Natrix.JSCore.IJSObjectProxy<CredentialPropertiesOutput>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialPropertiesOutput(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Rk
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "rk");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "rk", value);
    }
}

#nullable disable