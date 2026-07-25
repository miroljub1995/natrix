// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EventListener: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventListener(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventListener(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventListener(global::Natrix.StdWeb.EventListenerCallback input): this()
    {
        HandleEvent = input;
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventListener(global::Natrix.StdWeb.EventListenerCallbackManaged input): this()
    {
        HandleEvent = input;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator EventListener(EventListenerCallback input)
    {
        return new global::Natrix.StdWeb.EventListener(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator EventListener(EventListenerCallbackManaged input)
    {
        return new global::Natrix.StdWeb.EventListener(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.EventListenerCallback HandleEvent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventListenerCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handleEvent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventListenerCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handleEvent", value);
    }
}

#nullable disable