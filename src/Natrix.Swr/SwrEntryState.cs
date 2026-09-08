namespace Natrix.Swr;

/// <summary>
/// The outcome of fetching a key, as a single value.
///
/// Data and error are one signal rather than two because effects re-run on every signal write:
/// published separately, an effect would observe the moment where the error is already cleared
/// but the new value has not landed yet, and render a spurious loading state between two frames
/// of real content. <see cref="HasData"/> carries what <see cref="Data"/> alone cannot, that a
/// fetch legitimately returned <c>default</c>.
/// </summary>
internal sealed record SwrEntryState<TData>(bool HasData, TData? Data, Exception? Error)
{
    public static readonly SwrEntryState<TData> Empty = new(false, default, null);
}
