using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class LegendProps : GlobalHtmlComponentProps<HTMLLegendElement>
{
}

public class LegendEvents : HtmlElementComponentEvents<HTMLLegendElement>
{
}

public class Legend() : BaseNonVoidDomComponent<HTMLLegendElement, LegendProps, LegendEvents>("legend")
{
}
