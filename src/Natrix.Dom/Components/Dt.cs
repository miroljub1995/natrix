using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DtProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class DtEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Dt() : BaseNonVoidDomComponent<HTMLElement, DtProps, DtEvents>("dt")
{
}
