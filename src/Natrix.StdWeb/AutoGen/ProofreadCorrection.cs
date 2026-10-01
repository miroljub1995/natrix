// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProofreadCorrection: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProofreadCorrection>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreadCorrection(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProofreadCorrection global::Natrix.JSCore.IJSObjectProxy<ProofreadCorrection>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreadCorrection(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong StartIndex
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "startIndex");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "startIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong EndIndex
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "endIndex");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "endIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Correction
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "correction");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "correction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CorrectionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CorrectionType>> Types
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CorrectionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CorrectionType>>>.Get(JSObject, "types");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CorrectionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CorrectionType>>>.Set(JSObject, "types", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Explanation
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "explanation");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "explanation", value);
    }
}

#nullable disable