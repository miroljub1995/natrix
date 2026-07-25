using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DdProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class DdEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Dd() : BaseNonVoidDomComponent<HTMLElement, DdProps, DdEvents>("dd")
{
}
