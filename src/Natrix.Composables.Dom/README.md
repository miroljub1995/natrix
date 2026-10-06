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

Sets the document title and meta tags from the components that are mounted, on the server and in the browser —
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

### Meta tags

`Meta` contributes `<meta>` tags, resolved the way unhead resolves them. Each is identified by
exactly one of `Name`, `Property` (Open Graph) or `HttpEquiv`, and each key resolves on its own: the
latest call with non-`null` content for it wins, so a page can replace its layout's description and
leave the rest alone.

A call can repeat the keys that take a list — `og:image`, `og:video`, `og:audio`, `twitter:image`,
`article:tag` and the like, plus the structured properties under them (`og:image:width`, …). The
winning call contributes all of its tags for such a key, replacing an earlier call's list as a whole.
For any other key a call's last tag counts. Tags are written in the order the winning calls listed
them, so each `og:image:width` stays after its `og:image`.

```csharp
// Layout
UseHead(new HeadInput
{
    Meta =
    [
        new HeadMeta { Name = "description", Content = "Reactive UIs in .NET".ToConstSignal() },
        new HeadMeta { Property = "og:site_name", Content = "Natrix".ToConstSignal() },
    ],
});

// Page — replaces the description, keeps the site name
UseHead(new HeadInput
{
    Meta =
    [
        new HeadMeta { Name = "description", Content = new Computed<string?>(() => todo.Value.Summary) },
        new HeadMeta { Property = "og:image", Content = "/todo-1.png".ToConstSignal() },
        new HeadMeta { Property = "og:image:width", Content = "1200".ToConstSignal() },
        new HeadMeta { Property = "og:image", Content = "/todo-2.png".ToConstSignal() },
        new HeadMeta { Property = "og:image:width", Content = "800".ToConstSignal() },
    ],
});
```

In the browser, the title the document had when the host mounted is shown while no component sets
one and put back when the host is disposed. Meta tags work the same way: the tags the
document already has for a key are reused first and get their content back once no component sets
it, and tags the head added are removed. If a key resolves to fewer tags than the document had, the
extra ones lose their `content` until then. On a server-rendered page that is what the server wrote, so hydrating changes nothing the
visitor can see.
