using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TableProps : GlobalHtmlComponentProps<HTMLTableElement>
{
}

public class TableEvents : HtmlElementComponentEvents<HTMLTableElement>
{
}

public class Table() : BaseNonVoidDomComponent<HTMLTableElement, TableProps, TableEvents>("table")
{
}
