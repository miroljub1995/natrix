// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnimationTriggerOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AnimationTriggerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationTriggerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AnimationTriggerOptions global::Natrix.JSCore.IJSObjectProxy<AnimationTriggerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationTriggerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTimeline? Timeline
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTimeline>.Get(JSObject, "timeline");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AnimationTimeline>.Set(JSObject, "timeline", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTriggerBehavior? Behavior
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior>.Get(JSObject, "behavior");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior>.Set(JSObject, "behavior", value);
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
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor> ExitRangeStart
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "exitRangeStart");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "exitRangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor> ExitRangeEnd
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "exitRangeEnd");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimelineRangeOffset>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "exitRangeEnd", value);
    }
}

#nullable disable