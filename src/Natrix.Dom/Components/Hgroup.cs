using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class HgroupProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class HgroupEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Hgroup() : BaseNonVoidDomComponent<HTMLElement, HgroupProps, HgroupEvents>("hgroup")
{
}
