using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BdoProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class BdoEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Bdo() : BaseNonVoidDomComponent<HTMLElement, BdoProps, BdoEvents>("bdo")
{
}
