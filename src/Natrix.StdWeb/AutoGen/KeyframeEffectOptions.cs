// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KeyframeEffectOptions: global::Natrix.StdWeb.EffectTiming
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeEffectOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeEffectOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CompositeOperation Composite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CompositeOperation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "composite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CompositeOperation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "composite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? PseudoElement
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "pseudoElement");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "pseudoElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IterationCompositeOperation IterationComposite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.IterationCompositeOperation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iterationComposite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.IterationCompositeOperation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iterationComposite", value);
    }
}

#nullable disable