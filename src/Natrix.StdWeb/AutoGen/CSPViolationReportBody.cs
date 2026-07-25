// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSPViolationReportBody: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSPViolationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSPViolationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "documentURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "documentURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Referrer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "referrer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "referrer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? BlockedURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "blockedURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "blockedURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EffectiveDirective
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "effectiveDirective");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "effectiveDirective", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OriginalPolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "originalPolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "originalPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Sample
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sample");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sample", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition Disposition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort StatusCode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "statusCode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "statusCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? LineNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "columnNumber", value);
    }
}

#nullable disable