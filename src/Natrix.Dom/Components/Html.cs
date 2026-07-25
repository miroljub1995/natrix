using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class HtmlProps : GlobalHtmlComponentProps<HTMLHtmlElement>
{
}

public class HtmlEvents : HtmlElementComponentEvents<HTMLHtmlElement>
{
}

public class Html() : BaseNonVoidDomComponent<HTMLHtmlElement, HtmlProps, HtmlEvents>("html")
{
}
