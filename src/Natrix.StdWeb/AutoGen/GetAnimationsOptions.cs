// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GetAnimationsOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GetAnimationsOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GetAnimationsOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GetAnimationsOptions global::Natrix.JSCore.IJSObjectProxy<GetAnimationsOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GetAnimationsOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Subtree
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "subtree");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "subtree", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PseudoElement
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "pseudoElement");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "pseudoElement", value);
    }
}

#nullable disable