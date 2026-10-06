// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public sealed partial class InstallResult: global::Natrix.JSCore.IJSEnum<InstallResult>
{
    private readonly string _value;

    private InstallResult(string value)
    {
        _value = value;
    }

    public static readonly InstallResult Success = new("success");
    public static readonly InstallResult Aborted = new("aborted");
    public static readonly InstallResult Invalid_data = new("invalid_data");

    public override string ToString() => _value;

    public static InstallResult Create(string value) => value switch
    {
        "success" => Success,
        "aborted" => Aborted,
        "invalid_data" => Invalid_data,
        _ => throw new ArgumentException($"Invalid value \"{value}\" for InstallResult", nameof(value)),
    };
}

#nullable disable