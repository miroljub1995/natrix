using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class SearchInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class LanguageSearch : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private static readonly string[] Languages =
                ["C#", "F#", "Go", "Haskell", "Java", "Kotlin", "Python", "Rust", "Swift", "TypeScript"];

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var query = new Signal<string>("");
                var matches = new Computed<IReadOnlyList<string>>(() =>
                    [.. Languages.Where(l => l.Contains(query.Value.Trim(), StringComparison.OrdinalIgnoreCase))]);

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "search".ToConstSignal(),
                            Placeholder = "Filter languages".ToConstSignal(),
                            Value = query,
                        },
                        Events = new InputEvents { OnInput = query.ToDomEvent() },
                    },
                    new Ul
                    {
                        Props = new UlProps(),
                        Children =
                        [
                            // Keyed by name: a language that stays in the list keeps its <li>.
                            new ForEach<string, string>
                            {
                                Items = matches,
                                Key = language => language,
                                ElementSetup = language =>
                                [
                                    new Li { Props = new LiProps(), Children = [new DomText { Text = language }] },
                                ],
                            },
                        ],
                    },
                ];
            }
        }
        """;

    private static readonly string[] Languages =
        ["C#", "F#", "Go", "Haskell", "Java", "Kotlin", "Python", "Rust", "Swift", "TypeScript"];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var query = new Signal<string>("");
        var matches = new Computed<IReadOnlyList<string>>(() =>
            [.. Languages.Where(l => l.Contains(query.Value.Trim(), StringComparison.OrdinalIgnoreCase))]);

        return
        [
            Stack(
                Field("Search", "inputs-search-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-search-field".ToConstSignal(),
                        Type = "search".ToConstSignal(),
                        Placeholder = "Filter languages".ToConstSignal(),
                        Value = query,
                        Class = FieldClass.ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = query.ToDomEvent() },
                }),
                new Ul
                {
                    Props = new UlProps
                    {
                        Class = "flex min-h-[4.5rem] flex-wrap content-start gap-2".ToConstSignal(),
                    },
                    Children =
                    [
                        new ForEach<string, string>
                        {
                            Items = matches,
                            Key = language => language,
                            ElementSetup = language =>
                            [
                                new Li
                                {
                                    Props = new LiProps
                                    {
                                        Class = "rounded-full bg-indigo-50 dark:bg-indigo-500/10 px-3 py-1 font-mono text-sm text-indigo-700 dark:text-indigo-300".ToConstSignal(),
                                    },
                                    Children = [new DomText { Text = language }],
                                },
                            ],
                        },
                    ],
                },
                Hint(new Computed<string>(() => $"{matches.Value.Count} of {Languages.Length} languages"))),
        ];
    }
}
