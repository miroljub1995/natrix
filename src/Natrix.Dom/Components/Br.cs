using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BrProps : GlobalHtmlComponentProps<HTMLBRElement>
{
}

public class BrEvents : HtmlElementComponentEvents<HTMLBRElement>
{
}

public class Br() : BaseVoidDomComponent<HTMLBRElement, BrProps, BrEvents>("br")
{
}
