using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class HeaderProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class HeaderEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Header() : BaseNonVoidDomComponent<HTMLElement, HeaderProps, HeaderEvents>("header")
{
}
