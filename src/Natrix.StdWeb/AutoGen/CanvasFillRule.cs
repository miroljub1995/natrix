// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class CanvasFillRule: global::Natrix.JSCore.IJSEnum<CanvasFillRule>
{
    private readonly string _value;

    private CanvasFillRule(string value)
    {
        _value = value;
    }

    public static readonly CanvasFillRule Nonzero = new("nonzero");
    public static readonly CanvasFillRule Evenodd = new("evenodd");

    public override string ToString() => _value;

    public static CanvasFillRule Create(string value) => value switch
    {
        "nonzero" => Nonzero,
        "evenodd" => Evenodd,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for CanvasFillRule", nameof(value)),
    };
}

#nullable disable