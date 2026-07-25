// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RadioNodeList: global::Natrix.StdWeb.NodeList
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RadioNodeList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "value", value);
    }
}

#nullable disable