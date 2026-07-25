using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class CaptionProps : GlobalHtmlComponentProps<HTMLTableCaptionElement>
{
}

public class CaptionEvents : HtmlElementComponentEvents<HTMLTableCaptionElement>
{
}

public class Caption() : BaseNonVoidDomComponent<HTMLTableCaptionElement, CaptionProps, CaptionEvents>("caption")
{
}
