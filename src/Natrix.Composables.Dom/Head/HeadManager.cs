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
    }

    /// <summary>
    /// The title to show, with the winning template applied, or <c>null</c> when no entry sets
    /// one.
    /// </summary>
    public IReadOnlySignal<string?> Title { get; }

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
}
