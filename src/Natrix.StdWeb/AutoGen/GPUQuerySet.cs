// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUQuerySet: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUQuerySet>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUQuerySet(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUQuerySet global::Natrix.JSCore.IJSObjectProxy<GPUQuerySet>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUQuerySet>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Destroy()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "destroy", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUQueryType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUQueryType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Count
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "count");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable