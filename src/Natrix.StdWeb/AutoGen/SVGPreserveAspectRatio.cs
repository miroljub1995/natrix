// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPreserveAspectRatio: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPreserveAspectRatio(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "align");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MeetOrSlice
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "meetOrSlice");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "meetOrSlice", value);
    }
}

#nullable disable