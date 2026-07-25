using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class FooterProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class FooterEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Footer() : BaseNonVoidDomComponent<HTMLElement, FooterProps, FooterEvents>("footer")
{
}
