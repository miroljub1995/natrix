using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class EmProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class EmEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Em() : BaseNonVoidDomComponent<HTMLElement, EmProps, EmEvents>("em")
{
}
