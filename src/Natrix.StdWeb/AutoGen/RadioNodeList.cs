// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RadioNodeList: global::Natrix.StdWeb.NodeList, global::Natrix.JSCore.IJSObjectProxy<RadioNodeList>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RadioNodeList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RadioNodeList global::Natrix.JSCore.IJSObjectProxy<RadioNodeList>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RadioNodeList>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }
}

#nullable disable