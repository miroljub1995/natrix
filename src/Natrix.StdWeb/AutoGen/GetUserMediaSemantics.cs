// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class GetUserMediaSemantics: global::Natrix.JSCore.IJSEnum<GetUserMediaSemantics>
{
    private readonly string _value;

    private GetUserMediaSemantics(string value)
    {
        _value = value;
    }

    public static readonly GetUserMediaSemantics Browser_chooses = new("browser-chooses");
    public static readonly GetUserMediaSemantics User_chooses = new("user-chooses");

    public override string ToString() => _value;

    public static GetUserMediaSemantics Create(string value) => value switch
    {
        "browser-chooses" => Browser_chooses,
        "user-chooses" => User_chooses,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for GetUserMediaSemantics", nameof(value)),
    };
}

#nullable disable