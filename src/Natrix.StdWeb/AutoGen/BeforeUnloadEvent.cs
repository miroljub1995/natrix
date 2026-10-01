// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BeforeUnloadEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<BeforeUnloadEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BeforeUnloadEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BeforeUnloadEvent global::Natrix.JSCore.IJSObjectProxy<BeforeUnloadEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BeforeUnloadEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReturnValue
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "returnValue");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "returnValue", value);
    }
}

#nullable disable