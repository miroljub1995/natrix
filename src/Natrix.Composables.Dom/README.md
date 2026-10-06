# Natrix.Composables.Dom

Composables for Natrix components, in the spirit of [VueUse](https://vueuse.org/): small
functions a component calls from its `Setup`, which tie what they set up to the component and
undo it when the component unmounts.

```bash
dotnet add package Natrix.Composables.Dom
```

They are all on one class. Import it statically and call them the way a Vue component calls
VueUse:

```csharp
using static Natrix.Composables.Dom.DomComposables;
```

Every composable here works on either host. Which host it is on comes from what the application
registered, not from where the code runs, so a server render executed in the browser behaves as a
server render.

## UseHead

Sets the document title from the components that are mounted, on the server and in the browser —
the equivalent of unhead's `useHead`, which VueUse builds on.

### Setup

Register the head on each host, for what that host renders into:

```csharp
// Server: renders the page as markup.
new NatrixHostBuilder()
    .UseRootRenderer(root)
    .UseServerHead()
    …

// Browser: mounts into the live document.
new NatrixHostBuilder()
    .UseRootElement(appElement)
    .UseClientHead()
    …
```

On the server, place `HeadTags` inside the page's `<head>`, in place of a hard-coded `<title>`:

```csharp
new Head { Props = new HeadProps(), Children = [new Meta { … }, new HeadTags { Props = new NoProps() }] }
```

The head mounts before the body, so the components that set a title have not been set up when it
does. That is fine: `HeadTags` follows the resolved title, and the server tree stays live until the
response is written, so the page carries the title the finished tree resolves to.

### Usage

```csharp
protected override IComponent[] Setup(out NoExpose exposed)
{
    UseHead(new HeadInput { Title = new Computed<string?>(() => user.Value.Name) });
    …
}
```

Values are signals, so the title follows them. Calls stack in the order they were made, and the
latest one that sets a property wins. A layout is set up before the page it renders, so a page
overrides its layout, and when the page unmounts the layout's title is back. A title of `null`
contributes nothing, so the title falls back to an earlier call.

`TitleTemplate` wraps the title that wins, so a layout adds the site name once and pages set only
their own part:

```csharp
// Layout
UseHead(new HeadInput { TitleTemplate = title => $"{title} · Natrix" });

// Page — "Todo · Natrix"
UseHead(new HeadInput { Title = "Todo".ToConstSignal() });

// Home page — just "Natrix"
UseHead(new HeadInput { Title = "Natrix".ToConstSignal(), TitleTemplate = title => title });
```

In the browser, the title the document had when the host mounted is shown while no component sets
one and put back when the host is disposed. On a server-rendered page that is the title the server
wrote, so hydrating changes nothing the visitor can see.
