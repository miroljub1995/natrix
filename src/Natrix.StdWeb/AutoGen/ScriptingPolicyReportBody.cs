// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScriptingPolicyReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<ScriptingPolicyReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScriptingPolicyReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ScriptingPolicyReportBody global::Natrix.JSCore.IJSObjectProxy<ScriptingPolicyReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScriptingPolicyReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ViolationType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "violationType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "violationType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ViolationURL
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "violationURL");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "violationURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ViolationSample
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "violationSample");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "violationSample", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Lineno
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lineno");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lineno", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Colno
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "colno");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "colno", value);
    }
}

#nullable disable