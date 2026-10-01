// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SecurityPolicyViolationEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<SecurityPolicyViolationEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SecurityPolicyViolationEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SecurityPolicyViolationEventInit global::Natrix.JSCore.IJSObjectProxy<SecurityPolicyViolationEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SecurityPolicyViolationEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DocumentURI
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "documentURI");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "documentURI", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Referrer
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrer");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BlockedURI
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "blockedURI");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "blockedURI", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ViolatedDirective
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "violatedDirective");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "violatedDirective", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EffectiveDirective
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "effectiveDirective");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "effectiveDirective", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OriginalPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "originalPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "originalPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceFile
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sourceFile");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sourceFile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Sample
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sample");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sample", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition Disposition
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition>.Get(JSObject, "disposition");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SecurityPolicyViolationEventDisposition>.Set(JSObject, "disposition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort StatusCode
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "statusCode");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "statusCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint LineNumber
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lineNumber");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColumnNumber
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "columnNumber");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "columnNumber", value);
    }
}

#nullable disable