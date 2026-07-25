using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class VarProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class VarEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Var() : BaseNonVoidDomComponent<HTMLElement, VarProps, VarEvents>("var")
{
}
