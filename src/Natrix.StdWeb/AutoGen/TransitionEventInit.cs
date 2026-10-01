// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TransitionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<TransitionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TransitionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TransitionEventInit global::Natrix.JSCore.IJSObjectProxy<TransitionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TransitionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PropertyName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "propertyName");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "propertyName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ElapsedTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "elapsedTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "elapsedTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PseudoElement
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pseudoElement");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pseudoElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSTransition? Animation
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSTransition>.Get(JSObject, "animation");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSTransition>.Set(JSObject, "animation", value);
    }
}

#nullable disable