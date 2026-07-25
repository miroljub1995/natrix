using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BdiProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class BdiEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Bdi() : BaseNonVoidDomComponent<HTMLElement, BdiProps, BdiEvents>("bdi")
{
}
