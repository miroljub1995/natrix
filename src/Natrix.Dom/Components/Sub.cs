using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SubProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class SubEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Sub() : BaseNonVoidDomComponent<HTMLElement, SubProps, SubEvents>("sub")
{
}
