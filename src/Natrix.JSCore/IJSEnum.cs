namespace Natrix.JSCore;

/// <summary>
/// Implemented by generated WebIDL enums, which travel to and from JavaScript as strings.
/// </summary>
public interface IJSEnum<TSelf>
    where TSelf : class, IJSEnum<TSelf>
{
    static abstract TSelf Create(string value);
}
