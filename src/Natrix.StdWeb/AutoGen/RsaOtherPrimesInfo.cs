// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaOtherPrimesInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RsaOtherPrimesInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaOtherPrimesInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaOtherPrimesInfo global::Natrix.JSCore.IJSObjectProxy<RsaOtherPrimesInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaOtherPrimesInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string R
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "r");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "r", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string D
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "d");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string T
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "t");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "t", value);
    }
}

#nullable disable