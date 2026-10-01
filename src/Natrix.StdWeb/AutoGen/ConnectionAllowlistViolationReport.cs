// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConnectionAllowlistViolationReport: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<ConnectionAllowlistViolationReport>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConnectionAllowlistViolationReport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConnectionAllowlistViolationReport global::Natrix.JSCore.IJSObjectProxy<ConnectionAllowlistViolationReport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConnectionAllowlistViolationReport(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Connection
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "connection");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "connection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Allowlist
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "allowlist");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "allowlist", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ConnectionAllowlistDisposition Disposition
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ConnectionAllowlistDisposition>.Get(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ConnectionAllowlistDisposition>.Set(JSObject, "disposition", value);
    }
}

#nullable disable