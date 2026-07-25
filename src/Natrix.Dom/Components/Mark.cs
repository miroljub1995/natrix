using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class MarkProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class MarkEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Mark() : BaseNonVoidDomComponent<HTMLElement, MarkProps, MarkEvents>("mark")
{
}
