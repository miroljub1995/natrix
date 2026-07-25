using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class H6Props : GlobalHtmlComponentProps<HTMLHeadingElement>
{
}

public class H6Events : HtmlElementComponentEvents<HTMLHeadingElement>
{
}

public class H6() : BaseNonVoidDomComponent<HTMLHeadingElement, H6Props, H6Events>("h6")
{
}
