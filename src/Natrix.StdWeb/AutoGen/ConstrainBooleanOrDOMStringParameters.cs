// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConstrainBooleanOrDOMStringParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ConstrainBooleanOrDOMStringParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConstrainBooleanOrDOMStringParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConstrainBooleanOrDOMStringParameters global::Natrix.JSCore.IJSObjectProxy<ConstrainBooleanOrDOMStringParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConstrainBooleanOrDOMStringParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor> Exact
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "exact");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "exact", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor> Ideal
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "ideal");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "ideal", value);
    }
}

#nullable disable