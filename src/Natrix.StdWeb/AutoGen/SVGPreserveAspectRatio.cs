// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPreserveAspectRatio: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGPreserveAspectRatio>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPreserveAspectRatio(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGPreserveAspectRatio global::Natrix.JSCore.IJSObjectProxy<SVGPreserveAspectRatio>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGPreserveAspectRatio>(obj);

    public const ushort SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;

    public const ushort SVG_PRESERVEASPECTRATIO_NONE = 1;

    public const ushort SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;

    public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;

    public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;

    public const ushort SVG_PRESERVEASPECTRATIO_XMINYMID = 5;

    public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;

    public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;

    public const ushort SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;

    public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;

    public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;

    public const ushort SVG_MEETORSLICE_UNKNOWN = 0;

    public const ushort SVG_MEETORSLICE_MEET = 1;

    public const ushort SVG_MEETORSLICE_SLICE = 2;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Align
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MeetOrSlice
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "meetOrSlice");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "meetOrSlice", value);
    }
}

#nullable disable