using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class FigCaptionProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class FigCaptionEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class FigCaption() : BaseNonVoidDomComponent<HTMLElement, FigCaptionProps, FigCaptionEvents>("figcaption")
{
}
