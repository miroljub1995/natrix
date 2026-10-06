// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class SegmentType: global::Natrix.JSCore.IJSEnum<SegmentType>
{
    private readonly string _value;

    private SegmentType(string value)
    {
        _value = value;
    }

    public static readonly SegmentType Human_face = new("human-face");
    public static readonly SegmentType Left_eye = new("left-eye");
    public static readonly SegmentType Right_eye = new("right-eye");
    public static readonly SegmentType Eye = new("eye");
    public static readonly SegmentType Mouth = new("mouth");

    public override string ToString() => _value;

    public static SegmentType Create(string value) => value switch
    {
        "human-face" => Human_face,
        "left-eye" => Left_eye,
        "right-eye" => Right_eye,
        "eye" => Eye,
        "mouth" => Mouth,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for SegmentType", nameof(value)),
    };
}

#nullable disable