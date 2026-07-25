using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class NavProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class NavEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Nav() : BaseNonVoidDomComponent<HTMLElement, NavProps, NavEvents>("nav")
{
}
