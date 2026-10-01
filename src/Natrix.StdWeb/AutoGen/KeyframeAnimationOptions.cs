// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KeyframeAnimationOptions: global::Natrix.StdWeb.KeyframeEffectOptions, global::Natrix.JSCore.IJSObjectProxy<KeyframeAnimationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeAnimationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static KeyframeAnimationOptions global::Natrix.JSCore.IJSObjectProxy<KeyframeAnimationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyframeAnimationOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTimeline? Timeline
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTimeline>.Get(JSObject, "timeline");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTimeline>.Set(JSObject, "timeline", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor> RangeStart
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "rangeStart");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "rangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor> RangeEnd
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "rangeEnd");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "rangeEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTrigger? Trigger
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTrigger>.Get(JSObject, "trigger");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTrigger>.Set(JSObject, "trigger", value);
    }
}

#nullable disable