// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InterventionReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<InterventionReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InterventionReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InterventionReportBody global::Natrix.JSCore.IJSObjectProxy<InterventionReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InterventionReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "message", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SourceFile
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? LineNumber
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Set(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Set(JSObject, "columnNumber", value);
    }
}

#nullable disable