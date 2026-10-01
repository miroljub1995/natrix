// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XMLDocument: global::Natrix.StdWeb.Document, global::Natrix.JSCore.IJSObjectProxy<XMLDocument>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XMLDocument(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XMLDocument global::Natrix.JSCore.IJSObjectProxy<XMLDocument>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XMLDocument>(obj);


}

#nullable disable