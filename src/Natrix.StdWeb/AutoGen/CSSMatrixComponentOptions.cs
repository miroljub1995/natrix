// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMatrixComponentOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSMatrixComponentOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMatrixComponentOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSMatrixComponentOptions global::Natrix.JSCore.IJSObjectProxy<CSSMatrixComponentOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMatrixComponentOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Is2D
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "is2D");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "is2D", value);
    }
}

#nullable disable