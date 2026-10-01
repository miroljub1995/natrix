// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ReadableWritablePair: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ReadableWritablePair>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ReadableWritablePair(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ReadableWritablePair global::Natrix.JSCore.IJSObjectProxy<ReadableWritablePair>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ReadableWritablePair(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.ReadableStream Readable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Get(JSObject, "readable");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Set(JSObject, "readable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.WritableStream Writable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WritableStream>.Get(JSObject, "writable");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WritableStream>.Set(JSObject, "writable", value);
    }
}

#nullable disable