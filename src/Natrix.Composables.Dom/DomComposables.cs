namespace Natrix.Composables.Dom;

/// <summary>
/// Entry points for the DOM composables, one partial per area. Import it statically so a
/// component calls them the way a Vue component calls VueUse:
/// <code>
/// using static Natrix.Composables.Dom.DomComposables;
///
/// UseHead(new HeadInput { Title = "Todo".ToConstSignal() });
/// </code>
/// </summary>
/// <remarks>
/// Every composable here is only valid inside <c>Setup</c>, where it finds the component through
/// the ambient features and ties whatever it registers to the component's effect scope — so it is
/// undone when the component unmounts. Each one also has to be safe on either host. Which host it
/// is on is decided by the features the application registered, never by the operating system:
/// a server render can just as well run in the browser.
/// </remarks>
public static partial class DomComposables;
