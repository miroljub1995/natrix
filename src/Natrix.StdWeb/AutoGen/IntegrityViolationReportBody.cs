// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntegrityViolationReportBody: global::Natrix.StdWeb.ReportBody
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntegrityViolationReportBody(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntegrityViolationReportBody(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "documentURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "documentURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BlockedURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockedURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockedURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Destination
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "destination");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "destination", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReportOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportOnly");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportOnly", value);
    }
}

#nullable disable