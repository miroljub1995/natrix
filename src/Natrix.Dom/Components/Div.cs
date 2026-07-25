using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DivProps : GlobalHtmlComponentProps<HTMLDivElement>
{
}

public class DivEvents : HtmlElementComponentEvents<HTMLDivElement>
{
}

public class Div() : BaseNonVoidDomComponent<HTMLDivElement, DivProps, DivEvents>("div")
{
}