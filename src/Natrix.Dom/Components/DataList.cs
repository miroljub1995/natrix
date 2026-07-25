using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DataListProps : GlobalHtmlComponentProps<HTMLDataListElement>
{
}

public class DataListEvents : HtmlElementComponentEvents<HTMLDataListElement>
{
}

public class DataList() : BaseNonVoidDomComponent<HTMLDataListElement, DataListProps, DataListEvents>("datalist")
{
}
