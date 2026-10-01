// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class URLPatternInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<URLPatternInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static URLPatternInit global::Natrix.JSCore.IJSObjectProxy<URLPatternInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Username
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "username");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "username", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Password
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "password");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hostname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hostname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hostname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Port
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "port");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pathname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pathname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pathname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Search
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "search");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "search", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hash
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hash", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BaseURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "baseURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "baseURL", value);
    }
}

#nullable disable