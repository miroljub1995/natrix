using System.Collections.Immutable;
using Natrix.Signals;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// The application's head: every <see cref="HeadInput"/> currently contributed, in the order the
/// calls were made, and what they resolve to. Host-agnostic — the server writes the resolved head
/// into the page, the browser keeps the live document in step with it.
/// </summary>
/// <remarks>
/// Published to the tree by <c>UseServerHead</c> or <c>UseClientHead</c>, one per mounted host,
/// so a server rendering one request after another never mixes their heads.
/// </remarks>
internal sealed class HeadManager
{
    private readonly Signal<ImmutableList<HeadInput>> _entries = new([]);

    public HeadManager()
    {
        Title = new Computed<string?>(ResolveTitle);
        Meta = new Computed<IReadOnlyList<ResolvedHeadMeta>>(ResolveMeta, MetaComparer.Instance);
    }

    /// <summary>
    /// The title to show, with the winning template applied, or <c>null</c> when no entry sets
    /// one.
    /// </summary>
    public IReadOnlySignal<string?> Title { get; }

    /// <summary>
    /// The meta tags to write, in the order the winning calls were made and listed them. See
    /// <see cref="HeadInput.Meta"/> for which calls win.
    /// </summary>
    public IReadOnlySignal<IReadOnlyList<ResolvedHeadMeta>> Meta { get; }

    // Untracked: a component set up by a reactive update — an If branch flipping — runs its
    // Setup inside that update's effect, which would otherwise come to depend on the head.
    public void Add(HeadInput entry)
    {
        using var _ = new UntrackedScope();
        _entries.Value = _entries.Value.Add(entry);
    }

    public void Remove(HeadInput entry)
    {
        using var _ = new UntrackedScope();
        _entries.Value = _entries.Value.Remove(entry, ReferenceEqualityComparer.Instance);
    }

    private string? ResolveTitle()
    {
        var entries = _entries.Value;

        // Latest first, stopping at the winner: earlier entries cannot affect the result while
        // it stands, and the winner going back to null re-runs this anyway.
        string? title = null;
        for (var i = entries.Count - 1; i >= 0 && title is null; i--)
        {
            title = entries[i].Title?.Value;
        }

        if (title is null)
        {
            return null;
        }

        for (var i = entries.Count - 1; i >= 0; i--)
        {
            if (entries[i].TitleTemplate is { } template)
            {
                return template(title);
            }
        }

        return title;
    }

    private IReadOnlyList<ResolvedHeadMeta> ResolveMeta()
    {
        var entries = _entries.Value;

        // What each entry contributes: its tags that have content, each read once.
        var contributed = new List<(HeadMetaKey Key, string Content)>[entries.Count];

        // The entry that wins each key: the latest one that gives it content. It contributes the
        // whole key, so a page's images replace its layout's rather than adding to them.
        var winners = new Dictionary<HeadMetaKey, int>();

        for (var i = 0; i < entries.Count; i++)
        {
            contributed[i] = [];
            foreach (var meta in entries[i].Meta ?? [])
            {
                if (meta.Content.Value is { } content)
                {
                    contributed[i].Add((meta.Key, content));
                    winners[meta.Key] = i;
                }
            }
        }

        // In the order the winning entries made the calls and listed the tags, so structured
        // properties stay after the og:image they describe.
        var resolved = new List<ResolvedHeadMeta>();
        var occurrences = new Dictionary<HeadMetaKey, int>();

        for (var i = 0; i < entries.Count; i++)
        {
            var tags = contributed[i];
            for (var j = 0; j < tags.Count; j++)
            {
                var (key, content) = tags[j];
                if (winners[key] != i || (!key.IsRepeatable && IsRepeatedLater(tags, j)))
                {
                    continue;
                }

                var occurrence = occurrences.GetValueOrDefault(key);
                occurrences[key] = occurrence + 1;
                resolved.Add(new ResolvedHeadMeta(key, occurrence, content));
            }
        }

        return resolved;
    }

    // Within one call, the last tag for a key that cannot repeat is the one that counts.
    private static bool IsRepeatedLater(List<(HeadMetaKey Key, string Content)> tags, int index)
    {
        for (var i = index + 1; i < tags.Count; i++)
        {
            if (tags[i].Key == tags[index].Key)
            {
                return true;
            }
        }

        return false;
    }

    // Resolving builds a new list every time; compare by contents so an update that changes no
    // tag does not reach the page.
    private sealed class MetaComparer : IEqualityComparer<IReadOnlyList<ResolvedHeadMeta>>
    {
        public static readonly MetaComparer Instance = new();

        public bool Equals(IReadOnlyList<ResolvedHeadMeta>? x, IReadOnlyList<ResolvedHeadMeta>? y) =>
            ReferenceEquals(x, y) || (x is not null && y is not null && x.SequenceEqual(y));

        public int GetHashCode(IReadOnlyList<ResolvedHeadMeta> obj) => obj.Count;
    }
}
