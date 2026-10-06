// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class HumanFaceDetectionModeEnum: global::Natrix.JSCore.IJSEnum<HumanFaceDetectionModeEnum>
{
    private readonly string _value;

    private HumanFaceDetectionModeEnum(string value)
    {
        _value = value;
    }

    public static readonly HumanFaceDetectionModeEnum None = new("none");
    public static readonly HumanFaceDetectionModeEnum Bounding_box = new("bounding-box");
    public static readonly HumanFaceDetectionModeEnum Bounding_box_with_landmark_center_point = new("bounding-box-with-landmark-center-point");

    public override string ToString() => _value;

    public static HumanFaceDetectionModeEnum Create(string value) => value switch
    {
        "none" => None,
        "bounding-box" => Bounding_box,
        "bounding-box-with-landmark-center-point" => Bounding_box_with_landmark_center_point,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for HumanFaceDetectionModeEnum", nameof(value)),
    };
}

#nullable disable