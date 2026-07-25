using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class UlProps : GlobalHtmlComponentProps<HTMLUListElement>
{
}

public class UlEvents : HtmlElementComponentEvents<HTMLUListElement>
{
}

public class Ul() : BaseNonVoidDomComponent<HTMLUListElement, UlProps, UlEvents>("ul")
{
}
