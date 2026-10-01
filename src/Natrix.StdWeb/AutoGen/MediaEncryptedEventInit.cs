// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaEncryptedEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<MediaEncryptedEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaEncryptedEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaEncryptedEventInit global::Natrix.JSCore.IJSObjectProxy<MediaEncryptedEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaEncryptedEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InitDataType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "initDataType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "initDataType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer? InitData
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "initData");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "initData", value);
    }
}

#nullable disable