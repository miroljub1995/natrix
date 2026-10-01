// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EncapsulatedBits: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EncapsulatedBits>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncapsulatedBits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EncapsulatedBits global::Natrix.JSCore.IJSObjectProxy<EncapsulatedBits>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncapsulatedBits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer SharedKey
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "sharedKey");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "sharedKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer Ciphertext
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "ciphertext");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "ciphertext", value);
    }
}

#nullable disable