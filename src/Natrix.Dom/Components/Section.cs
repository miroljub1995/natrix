using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SectionProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class SectionEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Section() : BaseNonVoidDomComponent<HTMLElement, SectionProps, SectionEvents>("section")
{
}
