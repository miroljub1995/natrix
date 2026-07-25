using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class StrongProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class StrongEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Strong() : BaseNonVoidDomComponent<HTMLElement, StrongProps, StrongEvents>("strong")
{
}
