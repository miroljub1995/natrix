using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BodyProps : GlobalHtmlComponentProps<HTMLBodyElement>
{
}

public class BodyEvents : HtmlElementComponentEvents<HTMLBodyElement>
{
}

public class Body() : BaseNonVoidDomComponent<HTMLBodyElement, BodyProps, BodyEvents>("body")
{
}
