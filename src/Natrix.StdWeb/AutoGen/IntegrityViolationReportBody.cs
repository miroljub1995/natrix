// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntegrityViolationReportBody: global::Natrix.StdWeb.ReportBody, global::Natrix.JSCore.IJSObjectProxy<IntegrityViolationReportBody>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntegrityViolationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IntegrityViolationReportBody global::Natrix.JSCore.IJSObjectProxy<IntegrityViolationReportBody>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntegrityViolationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "documentURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "documentURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BlockedURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "blockedURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "blockedURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Destination
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "destination");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "destination", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReportOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "reportOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "reportOnly", value);
    }
}

#nullable disable