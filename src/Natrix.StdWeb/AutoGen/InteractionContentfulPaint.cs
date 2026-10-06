// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InteractionContentfulPaint: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<InteractionContentfulPaint>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InteractionContentfulPaint(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InteractionContentfulPaint global::Natrix.JSCore.IJSObjectProxy<InteractionContentfulPaint>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<InteractionContentfulPaint>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LargestContentfulPaint LargestContentfulPaint
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LargestContentfulPaint>.Get(JSObject, "largestContentfulPaint");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong InteractionId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "interactionId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PaintTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "paintTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? PresentationTime
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "presentationTime");
    }
}

#nullable disable