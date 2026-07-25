using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class H4Props : GlobalHtmlComponentProps<HTMLHeadingElement>
{
}

public class H4Events : HtmlElementComponentEvents<HTMLHeadingElement>
{
}

public class H4() : BaseNonVoidDomComponent<HTMLHeadingElement, H4Props, H4Events>("h4")
{
}
