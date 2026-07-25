// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConnectionAllowlistViolationReport: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConnectionAllowlistViolationReport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConnectionAllowlistViolationReport(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "url");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Connection
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connection");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> Allowlist
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "allowlist");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "allowlist", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ConnectionAllowlistDisposition Disposition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ConnectionAllowlistDisposition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ConnectionAllowlistDisposition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition", value);
    }
}

#nullable disable