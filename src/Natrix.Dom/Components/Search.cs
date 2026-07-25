using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SearchProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class SearchEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Search() : BaseNonVoidDomComponent<HTMLElement, SearchProps, SearchEvents>("search")
{
}
