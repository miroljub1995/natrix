// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGUnitTypes: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGUnitTypes>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGUnitTypes(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGUnitTypes global::Natrix.JSCore.IJSObjectProxy<SVGUnitTypes>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGUnitTypes>(obj);

    public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

    public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

    public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;
}

#nullable disable