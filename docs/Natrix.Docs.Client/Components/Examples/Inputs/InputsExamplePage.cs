using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class InputsExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    private record Example(string Id, string Title, string Tag, string FileName, string Source, string Description, Func<IComponent> Demo);

    private static readonly Example[] Examples =
    [
        new("text", "Text", "<input type=\"text\">", "NameField.cs", TextInputDemo.Source,
            "ToDomEvent turns a signal into an input handler that writes the field's value into it. Passing the same signal back as Value keeps the field and the state in step, in both directions.",
            () => new TextInputDemo { Props = new NoProps() }),
        new("password", "Password", "<input type=\"password\">", "PasswordField.cs", PasswordInputDemo.Source,
            "Props are signals too, so a Computed can drive the input's type: one click flips it between password and text. The strength score is plain C# over the value.",
            () => new PasswordInputDemo { Props = new NoProps() }),
        new("email", "Email", "<input type=\"email\">", "EmailField.cs", EmailInputDemo.Source,
            "The browser already knows what a valid address looks like. The handler reads the value and the browser's own validation message off the typed HTMLInputElement.",
            () => new EmailInputDemo { Props = new NoProps() }),
        new("url", "URL", "<input type=\"url\">", "UrlField.cs", UrlInputDemo.Source,
            "The value is parsed with System.Uri on every keystroke: the same .NET code that rendered the first result on the server.",
            () => new UrlInputDemo { Props = new NoProps() }),
        new("tel", "Telephone", "<input type=\"tel\">", "PhoneField.cs", TelInputDemo.Source,
            "A tel field is free text, but on phones it brings up the dial pad. The formatting lives in a Computed, which runs again whenever the signal changes.",
            () => new TelInputDemo { Props = new NoProps() }),
        new("search", "Search", "<input type=\"search\">", "LanguageSearch.cs", SearchInputDemo.Source,
            "A filter over a list, rendered with a keyed ForEach. Languages that stay in the results keep their elements; only the ones that come and go are added or removed.",
            () => new SearchInputDemo { Props = new NoProps() }),
        new("number", "Number", "<input type=\"number\">", "TicketField.cs", NumberInputDemo.Source,
            "Min, Max and Step constrain the spinner. The value still arrives as a string, so it is parsed where it is read, and anything out of range is caught there.",
            () => new NumberInputDemo { Props = new NoProps() }),
        new("range", "Range", "<input type=\"range\">", "FontSizeSlider.cs", RangeInputDemo.Source,
            "OnInput fires as the slider moves, not just when it is released. A Computed style updates the one attribute that depends on it.",
            () => new RangeInputDemo { Props = new NoProps() }),
        new("checkbox", "Checkbox", "<input type=\"checkbox\">", "TermsCheckbox.cs", CheckboxInputDemo.Source,
            "A checkbox's state is a bool, so it binds through Checked and OnChange rather than through its value. The button stays disabled until the box is ticked.",
            () => new CheckboxInputDemo { Props = new NoProps() }),
        new("radio", "Radio", "<input type=\"radio\">", "PlanPicker.cs", RadioInputDemo.Source,
            "Radio buttons that share a name form a group. Each one is checked while the selected plan is its own, and choosing one updates the selection.",
            () => new RadioInputDemo { Props = new NoProps() }),
        new("color", "Color", "<input type=\"color\">", "ColorPicker.cs", ColorInputDemo.Source,
            "The browser's colour picker always reports \"#rrggbb\". Convert.FromHexString splits that into channels for the rgb() readout.",
            () => new ColorInputDemo { Props = new NoProps() }),
        new("date", "Date", "<input type=\"date\">", "DateField.cs", DateInputDemo.Source,
            "The picker shows the date in the reader's locale, but the value is always ISO \"yyyy-MM-dd\". DateOnly parses it the same way on the server and in the browser.",
            () => new DateInputDemo { Props = new NoProps() }),
        new("time", "Time", "<input type=\"time\">", "TimeField.cs", TimeInputDemo.Source,
            "The value is 24-hour \"HH:mm\", even where the picker shows AM and PM. TimeOnly does the arithmetic.",
            () => new TimeInputDemo { Props = new NoProps() }),
        new("datetime-local", "Date and time", "<input type=\"datetime-local\">", "MeetingField.cs", DateTimeLocalInputDemo.Source,
            "A date and a time in one field, with no time zone attached. DateTime parses it, and the end of a 45-minute meeting follows.",
            () => new DateTimeLocalInputDemo { Props = new NoProps() }),
        new("month", "Month", "<input type=\"month\">", "MonthField.cs", MonthInputDemo.Source,
            "A year and a month with no day, as \"yyyy-MM\". Chromium browsers show a month picker; Firefox and Safari fall back to a text field.",
            () => new MonthInputDemo { Props = new NoProps() }),
        new("week", "Week", "<input type=\"week\">", "WeekField.cs", WeekInputDemo.Source,
            "An ISO 8601 week, as \"yyyy-Www\". ISOWeek turns it into the Monday it starts on. Like month, Firefox and Safari show a text field.",
            () => new WeekInputDemo { Props = new NoProps() }),
        new("file", "File", "<input type=\"file\">", "FilePicker.cs", FileInputDemo.Source,
            "Multiple lets the reader pick several files. The handler reads their names and sizes from the input's FileList; nothing is uploaded.",
            () => new FileInputDemo { Props = new NoProps() }),
        new("textarea", "Text area", "<textarea>", "BioField.cs", TextAreaDemo.Source,
            "Multi-line text binds exactly like an input. MaxLength stops typing at the limit, and the counters update as you write.",
            () => new TextAreaDemo { Props = new NoProps() }),
        new("select", "Select", "<select>", "CountryPicker.cs", SelectDemo.Source,
            "Value selects the matching option, on the server as well, so the page arrives with Japan already chosen.",
            () => new SelectDemo { Props = new NoProps() }),
        new("multiselect", "Multiple select", "<select multiple>", "ToppingsPicker.cs", MultiSelectDemo.Source,
            "With Multiple, bind Values to a list instead of Value to a string. ToDomEvent has an overload for lists that collects every selected option.",
            () => new MultiSelectDemo { Props = new NoProps() }),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new ExamplePage
            {
                Props = new ExamplePageProps
                {
                    Title = "Form Inputs".ToConstSignal(),
                    Id = "inputs-example".ToConstSignal(),
                    Description = "Every kind of form control, each bound to signals and running live above its code. Text-like fields bind their value with ToDomEvent; checkboxes, radio buttons and files read the element the event came from, through the typed DOM. Each listing is the whole component, minus labels and styling. Its first render came from the server, so the values you see before you type are the ones in the code.".ToConstSignal(),
                    MetaDescription = "Form inputs in C# with Natrix: text, number, range, checkbox, radio, select, date, color, file and more, each bound to signals and running live.".ToConstSignal(),
                    GitHubUrl = "https://github.com/miroljub1995/natrix/tree/main/docs/Natrix.Docs.Client/Components/Examples/Inputs".ToConstSignal(),
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () =>
                    [
                        Index(),
                        .. Examples.Select(Section),
                    ],
                },
            },
        ];
    }

    /// <summary>A link to every section, so the one input you came for is a click away.</summary>
    private static Nav Index() => new()
    {
        Props = new NavProps
        {
            AriaLabel = "Inputs on this page".ToConstSignal(),
            Class = "flex flex-wrap gap-2".ToConstSignal(),
        },
        Children =
        [
            .. Examples.Select(example => new A
            {
                Props = new AProps
                {
                    Href = $"#{SectionId(example)}".ToConstSignal(),
                    Class = "rounded-full border border-gray-200 dark:border-gray-800 px-3 py-1 text-sm text-gray-600 dark:text-gray-400 hover:border-indigo-400 dark:hover:border-indigo-500 hover:text-indigo-600 dark:hover:text-indigo-400 transition-colors".ToConstSignal(),
                },
                Children = [new DomText { Text = example.Title.ToConstSignal() }],
            }),
        ],
    };

    private static InputSection Section(Example example) => new()
    {
        Props = new InputSectionProps
        {
            Id = SectionId(example),
            Title = example.Title,
            Tag = example.Tag,
            Description = example.Description,
            FileName = example.FileName,
            Code = example.Source,
        },
        Slots = new InputSectionSlots
        {
            Demo = () => [example.Demo()],
        },
    };

    private static string SectionId(Example example) => $"input-{example.Id}";
}
