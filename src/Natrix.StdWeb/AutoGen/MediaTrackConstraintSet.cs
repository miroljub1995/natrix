// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaTrackConstraintSet: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaTrackConstraintSet>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackConstraintSet(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaTrackConstraintSet global::Natrix.JSCore.IJSObjectProxy<MediaTrackConstraintSet>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackConstraintSet(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> WhiteBalanceMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "whiteBalanceMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "whiteBalanceMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> ExposureMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "exposureMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "exposureMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> FocusMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "focusMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "focusMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>, global::Natrix.StdWeb.ConstrainPoint2DParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainPoint2DParameters>> PointsOfInterest
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>, global::Natrix.StdWeb.ConstrainPoint2DParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainPoint2DParameters>>>.Get(JSObject, "pointsOfInterest");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>, global::Natrix.StdWeb.ConstrainPoint2DParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainPoint2DParameters>>>.Set(JSObject, "pointsOfInterest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> ExposureCompensation
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "exposureCompensation");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "exposureCompensation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> ExposureTime
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "exposureTime");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "exposureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> ColorTemperature
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "colorTemperature");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "colorTemperature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Iso
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "iso");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "iso", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Brightness
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "brightness");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "brightness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Contrast
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "contrast");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "contrast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Saturation
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "saturation");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "saturation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Sharpness
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "sharpness");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "sharpness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> FocusDistance
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "focusDistance");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "focusDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Pan
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "pan");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "pan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Tilt
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "tilt");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "tilt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Zoom
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "zoom");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "zoom", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> Torch
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "torch");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "torch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> GestureReactions
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "gestureReactions");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "gestureReactions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> FaceFraming
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "faceFraming");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "faceFraming", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> EyeGazeCorrection
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "eyeGazeCorrection");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "eyeGazeCorrection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> VoiceIsolation
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "voiceIsolation");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "voiceIsolation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> HumanFaceDetectionMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "humanFaceDetectionMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "humanFaceDetectionMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> BackgroundSegmentationMask
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "backgroundSegmentationMask");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "backgroundSegmentationMask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>> Width
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>> Height
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> AspectRatio
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "aspectRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> FrameRate
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "frameRate");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "frameRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> FacingMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "facingMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "facingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> ResizeMode
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "resizeMode");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "resizeMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>> SampleRate
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Get(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Set(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>> SampleSize
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Get(JSObject, "sampleSize");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Set(JSObject, "sampleSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>> EchoCancellation
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>>>.Get(JSObject, "echoCancellation");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>>>.Set(JSObject, "echoCancellation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> AutoGainControl
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "autoGainControl");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "autoGainControl", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> NoiseSuppression
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "noiseSuppression");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "noiseSuppression", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>> Latency
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Get(JSObject, "latency");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.ConstrainDoubleRange, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDoubleRange>>>.Set(JSObject, "latency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>> ChannelCount
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Get(JSObject, "channelCount");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.StdWeb.ConstrainULongRange, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainULongRange>>>.Set(JSObject, "channelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> DeviceId
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "deviceId");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "deviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> GroupId
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "groupId");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "groupId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> BackgroundBlur
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "backgroundBlur");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "backgroundBlur", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> DisplaySurface
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "displaySurface");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "displaySurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> LogicalSurface
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "logicalSurface");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "logicalSurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>> Cursor
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Get(JSObject, "cursor");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.StdWeb.ConstrainDOMStringParameters, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainDOMStringParameters>>>.Set(JSObject, "cursor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> RestrictOwnAudio
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "restrictOwnAudio");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "restrictOwnAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>> SuppressLocalAudioPlayback
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Get(JSObject, "suppressLocalAudioPlayback");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ConstrainBooleanParameters, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ConstrainBooleanParameters>>>.Set(JSObject, "suppressLocalAudioPlayback", value);
    }
}

#nullable disable