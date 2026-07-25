using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TheadProps : GlobalHtmlComponentProps<HTMLTableSectionElement>
{
}

public class TheadEvents : HtmlElementComponentEvents<HTMLTableSectionElement>
{
}

public class Thead() : BaseNonVoidDomComponent<HTMLTableSectionElement, TheadProps, TheadEvents>("thead")
{
}
