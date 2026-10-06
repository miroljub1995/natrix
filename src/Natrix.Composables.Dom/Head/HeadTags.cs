using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// Renders the head that <see cref="DomComposables.UseHead"/> calls resolve to. Place it inside
/// the server-rendered <c>&lt;head&gt;</c>, in place of the tags it manages:
/// <code>
/// new Head { Props = new HeadProps(), Children = [new Meta { … }, new HeadTags { Props = new NoProps() }] }
/// </code>
/// </summary>
/// <remarks>
/// The head mounts ahead of the body, so when this is set up the components that call
/// <c>UseHead</c> have not been yet. That is fine: what it renders follows the resolved head, and
/// the server tree stays live until the response is written, so the page carries the head the
/// finished tree resolves to.
/// </remarks>
/// <exception cref="InvalidOperationException">
/// Mounted on a host that registered neither <c>UseServerHead</c> nor <c>UseClientHead</c>.
/// </exception>
public sealed class HeadTags : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var title = AppFeatures.Features.GetRequired<HeadManager>().Title;

        return
        [
            new If
            {
                Condition = new Computed<bool>(() => title.Value is not null),
                Then = () =>
                [
                    new Title
                    {
                        Props = new TitleProps(),
                        Children = [new DomText { Text = new Computed<string>(() => title.Value ?? "") }],
                    },
                ],
            },
        ];
    }
}
