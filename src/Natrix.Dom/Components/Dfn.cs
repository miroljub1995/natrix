using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DfnProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class DfnEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Dfn() : BaseNonVoidDomComponent<HTMLElement, DfnProps, DfnEvents>("dfn")
{
}
