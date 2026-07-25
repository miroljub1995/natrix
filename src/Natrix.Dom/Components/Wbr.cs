using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class WbrProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class WbrEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Wbr() : BaseVoidDomComponent<HTMLElement, WbrProps, WbrEvents>("wbr")
{
}
