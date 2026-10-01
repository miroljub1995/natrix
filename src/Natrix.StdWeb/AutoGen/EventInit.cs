// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EventInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EventInit global::Natrix.JSCore.IJSObjectProxy<EventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Bubbles
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "bubbles");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "bubbles", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Cancelable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "cancelable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "cancelable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Composed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "composed");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "composed", value);
    }
}

#nullable disable