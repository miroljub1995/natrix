// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KeyframeEffectOptions: global::Natrix.StdWeb.EffectTiming, global::Natrix.JSCore.IJSObjectProxy<KeyframeEffectOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeEffectOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static KeyframeEffectOptions global::Natrix.JSCore.IJSObjectProxy<KeyframeEffectOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeEffectOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CompositeOperation Composite
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperation>.Get(JSObject, "composite");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperation>.Set(JSObject, "composite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PseudoElement
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "pseudoElement");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "pseudoElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IterationCompositeOperation IterationComposite
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IterationCompositeOperation>.Get(JSObject, "iterationComposite");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IterationCompositeOperation>.Set(JSObject, "iterationComposite", value);
    }
}

#nullable disable