using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class FileInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class FilePicker : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private record PickedFile(string Name, ulong Size);

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var files = new Signal<IReadOnlyList<PickedFile>>([]);
                var total = new Computed<string>(() => files.Value.Count == 0
                    ? "No files yet"
                    : $"{files.Value.Count} files, {files.Value.Sum(f => (double)f.Size) / 1024:0.#} KB");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "file".ToConstSignal(),
                            Multiple = true.ToConstSignal(),
                        },
                        Events = new InputEvents
                        {
                            OnChange = e =>
                            {
                                // Nothing leaves the browser: this only reads names and sizes.
                                if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement { Files: { } list })
                                {
                                    var picked = new List<PickedFile>();
                                    for (uint i = 0; i < list.Length; i++)
                                    {
                                        var file = list.Item(i)!;
                                        picked.Add(new PickedFile(file.Name, file.Size));
                                    }

                                    files.Value = picked;
                                }
                            },
                        },
                    },
                    new Ul
                    {
                        Props = new UlProps(),
                        Children =
                        [
                            new ForEach<PickedFile, string>
                            {
                                Items = files,
                                Key = file => file.Name,
                                ElementSetup = file =>
                                [
                                    new Li { Props = new LiProps(), Children = [new DomText {
                                        Text = new Computed<string>(() => file.Value.Name) }] },
                                ],
                            },
                        ],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = total }],
                    },
                ];
            }
        }
        """;

    private record PickedFile(string Name, ulong Size);

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var files = new Signal<IReadOnlyList<PickedFile>>([]);
        var total = new Computed<string>(() => files.Value.Count == 0
            ? "No files yet"
            : $"{files.Value.Count} files, {files.Value.Sum(f => (double)f.Size) / 1024:0.#} KB");

        return
        [
            Stack(
                Field("Attachments", "inputs-file-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-file-field".ToConstSignal(),
                        Type = "file".ToConstSignal(),
                        Multiple = true.ToConstSignal(),
                        Class = "block w-full min-w-0 text-sm text-gray-600 dark:text-gray-400 file:mr-3 file:cursor-pointer file:rounded-md file:border-0 file:bg-indigo-600 file:px-4 file:py-2 file:text-sm file:font-medium file:text-white hover:file:bg-indigo-500".ToConstSignal(),
                    },
                    Events = new InputEvents
                    {
                        OnChange = e =>
                        {
                            if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement { Files: { } list })
                            {
                                var picked = new List<PickedFile>();
                                for (uint i = 0; i < list.Length; i++)
                                {
                                    var file = list.Item(i)!;
                                    picked.Add(new PickedFile(file.Name, file.Size));
                                }

                                files.Value = picked;
                            }
                        },
                    },
                }),
                new Ul
                {
                    Props = new UlProps
                    {
                        Class = "flex flex-col gap-1 text-sm".ToConstSignal(),
                    },
                    Children =
                    [
                        new ForEach<PickedFile, string>
                        {
                            Items = files,
                            Key = file => file.Name,
                            ElementSetup = file =>
                            [
                                new Li
                                {
                                    Props = new LiProps
                                    {
                                        Class = "flex justify-between gap-3 rounded-md bg-gray-100 dark:bg-gray-800/60 px-3 py-1.5".ToConstSignal(),
                                    },
                                    Children =
                                    [
                                        new Span
                                        {
                                            Props = new SpanProps
                                            {
                                                Class = "min-w-0 truncate text-gray-800 dark:text-gray-200".ToConstSignal(),
                                            },
                                            Children = [new DomText { Text = new Computed<string>(() => file.Value.Name) }],
                                        },
                                        new Span
                                        {
                                            Props = new SpanProps
                                            {
                                                Class = "shrink-0 font-mono text-gray-500 dark:text-gray-400".ToConstSignal(),
                                            },
                                            Children = [new DomText { Text = new Computed<string>(() => $"{file.Value.Size / 1024.0:0.#} KB") }],
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
                Hint(total)),
        ];
    }
}
