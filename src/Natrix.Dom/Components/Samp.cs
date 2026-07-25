using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SampProps : GlobalHtmlComponentProps<HTMLElement>
{
}

public class SampEvents : HtmlElementComponentEvents<HTMLElement>
{
}

public class Samp() : BaseNonVoidDomComponent<HTMLElement, SampProps, SampEvents>("samp")
{
}
