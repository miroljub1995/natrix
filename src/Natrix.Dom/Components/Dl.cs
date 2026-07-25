using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DlProps : GlobalHtmlComponentProps<HTMLDListElement>
{
}

public class DlEvents : HtmlElementComponentEvents<HTMLDListElement>
{
}

public class Dl() : BaseNonVoidDomComponent<HTMLDListElement, DlProps, DlEvents>("dl")
{
}
