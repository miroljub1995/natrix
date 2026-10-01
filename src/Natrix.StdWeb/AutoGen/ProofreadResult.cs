// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProofreadResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProofreadResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreadResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProofreadResult global::Natrix.JSCore.IJSObjectProxy<ProofreadResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreadResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CorrectedInput
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "correctedInput");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "correctedInput", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProofreadCorrection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProofreadCorrection>> Corrections
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProofreadCorrection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProofreadCorrection>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProofreadCorrection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProofreadCorrection>>>>(JSObject, "corrections");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProofreadCorrection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProofreadCorrection>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProofreadCorrection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProofreadCorrection>>>>(JSObject, "corrections", value);
    }
}

#nullable disable