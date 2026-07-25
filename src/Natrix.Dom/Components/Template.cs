using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TemplateProps : GlobalHtmlComponentProps<HTMLTemplateElement>
{
}

public class TemplateEvents : HtmlElementComponentEvents<HTMLTemplateElement>
{
}

public class Template() : BaseNonVoidDomComponent<HTMLTemplateElement, TemplateProps, TemplateEvents>("template")
{
}
