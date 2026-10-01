// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KeySystemTrackConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<KeySystemTrackConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeySystemTrackConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static KeySystemTrackConfiguration global::Natrix.JSCore.IJSObjectProxy<KeySystemTrackConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeySystemTrackConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Robustness
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "robustness");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "robustness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? EncryptionScheme
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "encryptionScheme");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "encryptionScheme", value);
    }
}

#nullable disable