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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "featureId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "featureId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? LineNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int?, global::Natrix.JSCore.Generics.NullableInt32Accessor>(JSObject, "columnNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Disposition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "disposition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AllowAttribute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "allowAttribute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "allowAttribute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SrcAttribute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "srcAttribute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "srcAttribute", value);
    }
}

#nullable disable