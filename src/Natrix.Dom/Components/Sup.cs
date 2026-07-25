using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SupProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class SupEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Sup() : BaseNonVoidDomComponent<HTMLElement, SupProps, SupEvents>("sup")
{
}
