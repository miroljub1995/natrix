using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TbodyProps : GlobalHtmlComponentProps<HTMLTableSectionElement>
{
}

public class TbodyEvents : HtmlElementComponentEvents<HTMLTableSectionElement>
{
}

public class Tbody() : BaseNonVoidDomComponent<HTMLTableSectionElement, TbodyProps, TbodyEvents>("tbody")
{
}
