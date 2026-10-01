using System.Runtime.InteropServices.JavaScript;

namespace Natrix.JSCore;

/// <summary>
/// Implemented by every proxy type so generic code can wrap a <see cref="JSObject"/> in it
/// without a shared, per-assembly lookup.
/// </summary>
public interface IJSObjectProxy<TSelf>
    where TSelf : JSObjectProxy, IJSObjectProxy<TSelf>
{
    static abstract TSelf Create(JSObject obj);
}
