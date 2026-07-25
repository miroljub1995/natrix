using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TfootProps : GlobalHtmlComponentProps<HTMLTableSectionElement>
{
}

public class TfootEvents : HtmlElementComponentEvents<HTMLTableSectionElement>
{
}

public class Tfoot() : BaseNonVoidDomComponent<HTMLTableSectionElement, TfootProps, TfootEvents>("tfoot")
{
}
