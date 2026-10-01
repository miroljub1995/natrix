// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CrashReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<CrashReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrashReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CrashReportBody global::Natrix.JSCore.IJSObjectProxy<CrashReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CrashReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Reason
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "reason", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Stack
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "stack");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "stack", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Is_top_level
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "is_top_level");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "is_top_level", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DocumentVisibilityState Visibility_state
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DocumentVisibilityState>.Get(JSObject, "visibility_state");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DocumentVisibilityState>.Set(JSObject, "visibility_state", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Crash_report_api
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "crash_report_api");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "crash_report_api", value);
    }
}

#nullable disable