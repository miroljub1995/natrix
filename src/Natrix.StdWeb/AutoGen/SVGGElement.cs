// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGGElement: global::Natrix.StdWeb.SVGGraphicsElement, global::Natrix.JSCore.IJSObjectProxy<SVGGElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGGElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGGElement global::Natrix.JSCore.IJSObjectProxy<SVGGElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGGElement>(obj);


}

#nullable disable