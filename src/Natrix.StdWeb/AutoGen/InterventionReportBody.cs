// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InterventionReportBody: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InterventionReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InterventionReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "id");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "message");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "message", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sourceFile", value);
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