using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class PictureProps : GlobalHtmlComponentProps<HTMLPictureElement>
{
}

public class PictureEvents : HtmlElementComponentEvents<HTMLPictureElement>
{
}

public class Picture() : BaseNonVoidDomComponent<HTMLPictureElement, PictureProps, PictureEvents>("picture")
{
}
