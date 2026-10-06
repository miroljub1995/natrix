using Natrix.Composables.Dom.Head;
using Natrix.Core.Features;
using Natrix.Signals;

namespace Natrix.Composables.Dom;

public static partial class DomComposables
{
    /// <summary>
    /// Contributes to the document head for as long as the calling component is mounted — the
    /// equivalent of unhead's <c>useHead</c>, which VueUse builds on.
    /// <code>
    /// UseHead(new HeadInput
    /// {
    ///     Title = new Computed&lt;string?&gt;(() =&gt; user.Value.Name),
    /// });
    /// </code>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Values are signals, so the head follows them; there is nothing to update by hand. The
    /// contribution is removed when the component unmounts, which brings back whatever an
    /// earlier call set — see <see cref="HeadInput"/> for how calls combine.
    /// </para>
    /// <para>
    /// On the server the head is written when the response is, not when <c>&lt;head&gt;</c>
    /// mounts, so components rendered further down the page still reach it.
    /// </para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Called outside <c>Setup</c>, the host registered neither <c>UseServerHead</c> nor
    /// <c>UseClientHead</c>, or a <see cref="HeadMeta"/> does not set exactly one of its
    /// <c>Name</c>, <c>Property</c> and <c>HttpEquiv</c>.
    /// </exception>
    public static void UseHead(HeadInput input)
    {
        ArgumentNullException.ThrowIfNull(input);

        // Fail at the call, not later while the head resolves.
        foreach (var meta in input.Meta ?? [])
        {
            _ = meta.Key;
        }

        var manager = AppFeatures.Features.GetRequired<HeadManager>();

        manager.Add(input);

        // Created in the component's own scope, so the cleanup runs when it unmounts.
        new Effect(onCleanup => onCleanup(() => manager.Remove(input)));
    }
}
