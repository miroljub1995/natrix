// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class LanguageModelToolResultType: global::Natrix.JSCore.IJSEnum<LanguageModelToolResultType>
{
    private readonly string _value;

    private LanguageModelToolResultType(string value)
    {
        _value = value;
    }

    public static readonly LanguageModelToolResultType Text = new("text");
    public static readonly LanguageModelToolResultType Image = new("image");
    public static readonly LanguageModelToolResultType Audio = new("audio");
    public static readonly LanguageModelToolResultType Object = new("object");

    public override string ToString() => _value;

    public static LanguageModelToolResultType Create(string value) => value switch
    {
        "text" => Text,
        "image" => Image,
        "audio" => Audio,
        "object" => Object,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for LanguageModelToolResultType", nameof(value)),
    };
}

#nullable disable