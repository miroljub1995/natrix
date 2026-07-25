using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class CodeProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class CodeEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Code() : BaseNonVoidDomComponent<HTMLElement, CodeProps, CodeEvents>("code")
{
}
