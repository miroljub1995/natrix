using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ArticleProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class ArticleEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Article() : BaseNonVoidDomComponent<HTMLElement, ArticleProps, ArticleEvents>("article")
{
}
