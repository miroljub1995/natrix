using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class PreProps : GlobalHtmlComponentProps<HTMLPreElement>
{
}

public class PreEvents : HtmlElementComponentEvents<HTMLPreElement>
{
}

public class Pre() : BaseNonVoidDomComponent<HTMLPreElement, PreProps, PreEvents>("pre")
{
}
