using System.Text.RegularExpressions;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Home;

public class CSharpCodeProps
{
    public required string Code { get; init; }
    public required string FileName { get; init; }
}

/// <summary>
/// Read-only C# listing with lightweight syntax highlighting, in an editor-style window.
/// </summary>
/// <remarks>
/// The highlighting is a single regex pass that colours what a reader scans for - keywords,
/// types, methods, strings, numbers and comments. It is not a C# lexer, and only needs to be right for
/// the snippets the docs show. Runs during setup, so the server renders it into the HTML.
/// </remarks>
public partial class CSharpCode : BaseComponent<CSharpCodeProps, NoEvents, NoSlots, NoExpose>
{
    private const string CommentClass = "text-gray-500 italic";
    private const string StringClass = "text-emerald-300";
    private const string NumberClass = "text-amber-300";
    private const string KeywordClass = "text-violet-400";
    private const string TypeClass = "text-sky-300";
    private const string MethodClass = "text-yellow-200";

    [GeneratedRegex("""
        (?<comment>//[^\n]*)
        |(?<string>\$?"(?:[^"\\\n]|\\.)*")
        |(?<number>\b\d+\b)
        |(?<keyword>\b(?:public|private|protected|internal|readonly|class|partial|static|override|out|var|new|return|default|using|namespace|void|int|string|bool|true|false|null|await|async)\b)
        |(?<method>\b[A-Z]\w*(?=\())
        |(?<plain>(?<=\.)[A-Z]\w*|\b[A-Z]\w*(?=\s*=[^=>]))
        |(?<type>\b[A-Z]\w*)
        """, RegexOptions.IgnorePatternWhitespace)]
    private static partial Regex TokenRegex();

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "overflow-hidden rounded-xl border border-gray-800 bg-gray-950 shadow-2xl shadow-indigo-500/10 ring-1 ring-white/5".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex items-center gap-2 border-b border-white/10 bg-white/[0.03] px-4 py-3".ToConstSignal(),
                        },
                        Children =
                        [
                            Dot("bg-red-400/80"),
                            Dot("bg-amber-400/80"),
                            Dot("bg-emerald-400/80"),
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "ml-3 min-w-0 truncate font-mono text-xs text-gray-400".ToConstSignal(),
                                },
                                Children = [new DomText { Text = Props.FileName.ToConstSignal() }],
                            },
                        ],
                    },
                    new Pre
                    {
                        Props = new PreProps
                        {
                            Class = "overflow-x-auto p-4 sm:p-5 font-mono text-[13px] leading-relaxed text-gray-200".ToConstSignal(),
                        },
                        Children =
                        [
                            new Code
                            {
                                Props = new CodeProps
                                {
                                    Class = "whitespace-pre".ToConstSignal(),
                                },
                                Children = Highlight(Props.Code),
                            },
                        ],
                    },
                ],
            },
        ];
    }

    private static Span Dot(string color) => new()
    {
        Props = new SpanProps
        {
            Class = ("h-3 w-3 shrink-0 rounded-full " + color).ToConstSignal(),
        },
    };

    private static IComponent[] Highlight(string code)
    {
        var components = new List<IComponent>();
        var position = 0;

        foreach (Match match in TokenRegex().Matches(code))
        {
            var tokenClass =
                match.Groups["comment"].Success ? CommentClass :
                match.Groups["string"].Success ? StringClass :
                match.Groups["number"].Success ? NumberClass :
                match.Groups["keyword"].Success ? KeywordClass :
                match.Groups["type"].Success ? TypeClass :
                match.Groups["method"].Success ? MethodClass :
                null;

            if (tokenClass is null)
            {
                // Members and property initializers stay in the base colour, so the types stand
                // out. Left in the pending run of plain text rather than emitted on their own: the
                // HTML parser merges adjacent text nodes, and the client would then hydrate against
                // fewer nodes than the server rendered.
                continue;
            }

            if (match.Index > position)
            {
                components.Add(new DomText { Text = code[position..match.Index].ToConstSignal() });
            }

            components.Add(new Span
            {
                Props = new SpanProps { Class = tokenClass.ToConstSignal() },
                Children = [new DomText { Text = match.Value.ToConstSignal() }],
            });

            position = match.Index + match.Length;
        }

        if (position < code.Length)
        {
            components.Add(new DomText { Text = code[position..].ToConstSignal() });
        }

        return [.. components];
    }
}
