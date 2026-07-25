using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class HrProps : GlobalHtmlComponentProps<HTMLHRElement>
{
}

public class HrEvents : HtmlElementComponentEvents<HTMLHRElement>
{
}

public class Hr() : BaseVoidDomComponent<HTMLHRElement, HrProps, HrEvents>("hr")
{
}
