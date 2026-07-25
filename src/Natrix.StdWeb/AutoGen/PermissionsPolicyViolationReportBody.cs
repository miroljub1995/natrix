// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PermissionsPolicyViolationReportBody: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionsPolicyViolationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionsPolicyViolationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FeatureId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "featureId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "featureId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? LineNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "columnNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Disposition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "disposition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AllowAttribute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "allowAttribute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "allowAttribute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SrcAttribute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "srcAttribute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "srcAttribute", value);
    }
}

#nullable disable