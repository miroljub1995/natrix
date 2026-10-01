// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeprecationReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<DeprecationReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeprecationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeprecationReportBody global::Natrix.JSCore.IJSObjectProxy<DeprecationReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeprecationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject? AnticipatedRemoval
    {
        get => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Get(JSObject, "anticipatedRemoval");
        set => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Set(JSObject, "anticipatedRemoval", value);
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