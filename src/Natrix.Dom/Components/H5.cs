using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class H5Props : GlobalHtmlComponentProps<HTMLHeadingElement>
{
}

public class H5Events : HtmlElementComponentEvents<HTMLHeadingElement>
{
}

public class H5() : BaseNonVoidDomComponent<HTMLHeadingElement, H5Props, H5Events>("h5")
{
}
