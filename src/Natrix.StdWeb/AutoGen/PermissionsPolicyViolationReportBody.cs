// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PermissionsPolicyViolationReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<PermissionsPolicyViolationReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionsPolicyViolationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PermissionsPolicyViolationReportBody global::Natrix.JSCore.IJSObjectProxy<PermissionsPolicyViolationReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionsPolicyViolationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FeatureId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "featureId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "featureId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? LineNumber
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.NullableInt32Accessor.Set(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.NullableInt32Accessor.Set(JSObject, "columnNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Disposition
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "disposition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AllowAttribute
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "allowAttribute");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "allowAttribute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SrcAttribute
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "srcAttribute");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "srcAttribute", value);
    }
}

#nullable disable