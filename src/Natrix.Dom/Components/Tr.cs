using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TrProps : GlobalHtmlComponentProps<HTMLTableRowElement>
{
}

public class TrEvents : HtmlElementComponentEvents<HTMLTableRowElement>
{
}

public class Tr() : BaseNonVoidDomComponent<HTMLTableRowElement, TrProps, TrEvents>("tr")
{
}
