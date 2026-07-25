// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CrashReportBody: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrashReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrashReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Reason
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reason", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Stack
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "stack");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "stack", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Is_top_level
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "is_top_level");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "is_top_level", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DocumentVisibilityState Visibility_state
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DocumentVisibilityState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "visibility_state");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DocumentVisibilityState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "visibility_state", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Crash_report_api
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "crash_report_api");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "crash_report_api", value);
    }
}

#nullable disable