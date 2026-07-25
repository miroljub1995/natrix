using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class NoscriptProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class NoscriptEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Noscript() : BaseNonVoidDomComponent<HTMLElement, NoscriptProps, NoscriptEvents>("noscript")
{
}
