// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderBundle: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPURenderBundle>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderBundle(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURenderBundle global::Natrix.JSCore.IJSObjectProxy<GPURenderBundle>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPURenderBundle>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable