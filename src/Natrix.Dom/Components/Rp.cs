using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class RpProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class RpEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Rp() : BaseNonVoidDomComponent<HTMLElement, RpProps, RpEvents>("rp")
{
}
