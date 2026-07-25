using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TitleProps : GlobalHtmlComponentProps<HTMLTitleElement>
{
}

public class TitleEvents : HtmlElementComponentEvents<HTMLTitleElement>
{
}

public class Title() : BaseNonVoidDomComponent<HTMLTitleElement, TitleProps, TitleEvents>("title")
{
}
