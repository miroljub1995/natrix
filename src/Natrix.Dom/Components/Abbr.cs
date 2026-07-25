using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class AbbrProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class AbbrEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Abbr() : BaseNonVoidDomComponent<HTMLElement, AbbrProps, AbbrEvents>("abbr")
{
}
