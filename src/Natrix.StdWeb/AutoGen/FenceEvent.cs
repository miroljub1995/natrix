// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FenceEvent: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FenceEvent>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FenceEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FenceEvent global::Natrix.JSCore.IJSObjectProxy<FenceEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FenceEvent(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EventType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "eventType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "eventType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EventData
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "eventData");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "eventData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FenceReportingDestination, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FenceReportingDestination>> Destination
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FenceReportingDestination, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FenceReportingDestination>>>.Get(JSObject, "destination");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FenceReportingDestination, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FenceReportingDestination>>>.Set(JSObject, "destination", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CrossOriginExposed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "crossOriginExposed");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "crossOriginExposed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Once
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "once");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "once", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DestinationURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "destinationURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "destinationURL", value);
    }
}

#nullable disable