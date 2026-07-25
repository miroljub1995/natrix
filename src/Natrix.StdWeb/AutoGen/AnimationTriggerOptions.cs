// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnimationTriggerOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationTriggerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationTriggerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTimeline? Timeline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationTimeline?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "timeline");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AnimationTimeline?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "timeline", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationTriggerBehavior? Behavior
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationTriggerBehavior?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "behavior");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AnimationTriggerBehavior?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "behavior", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> RangeStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeStart");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> RangeEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeEnd");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> ExitRangeStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exitRangeStart");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exitRangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> ExitRangeEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exitRangeEnd");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TimelineRangeOffset, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "exitRangeEnd", value);
    }
}

#nullable disable