using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core;
using Natrix.Core.Features;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// Gives an application a head for <see cref="DomComposables.UseHead"/> to contribute to. Pick
/// by what the host renders into, not by where it runs: a server render executed in the browser
/// still writes a page, and still wants <see cref="UseServerHead"/>.
/// </summary>
public static class NatrixHostBuilderHeadExtensions
{
    /// <summary>
    /// For a host that renders the page as markup. The head is written by
    /// <see cref="HeadTags"/>, which the page places inside its <c>&lt;head&gt;</c>.
    /// </summary>
    public static NatrixHostBuilder UseServerHead(this NatrixHostBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.Use(features => Publish(features));
    }

    /// <summary>
    /// For a host that mounts into the live document. Keeps <c>document.title</c> and the
    /// <c>&lt;meta&gt;</c> tags in <c>&lt;head&gt;</c> in step with what the mounted components
    /// resolve to.
    /// </summary>
    /// <remarks>
    /// What the document had is the fallback: its title is shown while no component sets one, a
    /// meta tag it already had gets its content back once no component sets it, and both are put
    /// back when the host is disposed; tags the head added are removed. On a page the server
    /// rendered, that is what the server wrote, so hydrating changes nothing the visitor can see.
    /// </remarks>
    [SupportedOSPlatform("browser")]
    public static NatrixHostBuilder UseClientHead(this NatrixHostBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.Use(features =>
        {
            var manager = Publish(features);
            var document = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document;
            var fallback = document.Title;

            // Mounted under the host's scope, so both are disposed with it.
            new Effect(_ => document.Title = manager.Title.Value ?? fallback);
            new Effect(onCleanup => onCleanup(() => document.Title = fallback));

            SyncMeta(document, manager);
        });
    }

    [SupportedOSPlatform("browser")]
    private static void SyncMeta(Document document, HeadManager manager)
    {
        var groups = new Dictionary<HeadMetaKey, ManagedMetaGroup>();

        new Effect(_ =>
        {
            var resolved = manager.Meta.Value;

            using var untracked = new UntrackedScope();

            // In resolved order, so tags the head adds go into the document in the order they
            // resolve: each og:image:width after its og:image.
            var counts = new Dictionary<HeadMetaKey, int>();
            foreach (var meta in resolved)
            {
                if (!groups.TryGetValue(meta.Key, out var group))
                {
                    groups.Add(meta.Key, group = ManagedMetaGroup.Claim(document, meta.Key));
                }

                group.Show(meta.Occurrence, meta.Content);
                counts[meta.Key] = meta.Occurrence + 1;
            }

            foreach (var (key, count) in counts)
            {
                groups[key].Trim(count);
            }

            foreach (var key in groups.Keys.Where(key => !counts.ContainsKey(key)).ToList())
            {
                groups[key].Release();
                groups.Remove(key);
            }
        });

        new Effect(onCleanup => onCleanup(() =>
        {
            foreach (var group in groups.Values)
            {
                group.Release();
            }

            groups.Clear();
        }));
    }

    /// <summary>
    /// The meta tags for one key while the head is driving it. The tags the document already had
    /// are reused first, and get their content back when released; the head adds what it needs
    /// beyond them, and removes those when released.
    /// </summary>
    /// <remarks>
    /// When the head resolves to fewer tags than the document had, the surplus ones lose their
    /// <c>content</c> attribute until released, which leaves them in place but says nothing.
    /// </remarks>
    [SupportedOSPlatform("browser")]
    private sealed class ManagedMetaGroup
    {
        private readonly Document _document;
        private readonly HTMLHeadElement _head;
        private readonly HeadMetaKey _key;
        private readonly List<(Element Element, string? Content)> _original;
        private readonly List<Element> _added = [];

        private ManagedMetaGroup(Document document, HTMLHeadElement head, HeadMetaKey key, List<(Element, string?)> original)
        {
            _document = document;
            _head = head;
            _key = key;
            _original = original;
        }

        public static ManagedMetaGroup Claim(Document document, HeadMetaKey key)
        {
            var head = document.Head
                ?? throw new InvalidOperationException("The document has no <head> to write meta tags into.");

            var value = key.Value.Replace("\\", "\\\\").Replace("\"", "\\\"");
            var nodes = head.QuerySelectorAll($"meta[{key.Attribute}=\"{value}\"]");

            var original = new List<(Element, string?)>((int)nodes.Length);
            for (uint i = 0; i < nodes.Length; i++)
            {
                var element = JSObjectProxyFactory.GetProxy<Element>(nodes.Item(i)!.JSObject);
                original.Add((element, element.GetAttribute("content")));
            }

            return new ManagedMetaGroup(document, head, key, original);
        }

        public void Show(int occurrence, string content) => Tag(occurrence).SetAttribute("content", content);

        /// <summary>Lets go of the tags past the first <paramref name="count"/>.</summary>
        public void Trim(int count)
        {
            for (var i = count; i < _original.Count; i++)
            {
                _original[i].Element.RemoveAttribute("content");
            }

            var keep = Math.Max(0, count - _original.Count);
            for (var i = _added.Count - 1; i >= keep; i--)
            {
                _added[i].Remove();
                _added.RemoveAt(i);
            }
        }

        public void Release()
        {
            foreach (var (element, content) in _original)
            {
                if (content is null)
                {
                    element.RemoveAttribute("content");
                }
                else
                {
                    element.SetAttribute("content", content);
                }
            }

            foreach (var element in _added)
            {
                element.Remove();
            }

            _added.Clear();
        }

        // The tag at this position among the key's tags, appending one when the document runs out.
        private Element Tag(int index)
        {
            if (index < _original.Count)
            {
                return _original[index].Element;
            }

            if (index - _original.Count < _added.Count)
            {
                return _added[index - _original.Count];
            }

            var element = _document.CreateElement("meta");
            element.SetAttribute(_key.Attribute, _key.Value);
            _head.AppendChild(element);
            _added.Add(element);
            return element;
        }
    }

    private static HeadManager Publish(IFeatureCollection features)
    {
        if (features.Get<HeadManager>() is not null)
        {
            throw new InvalidOperationException(
                "The head is already managed: register UseServerHead() or UseClientHead() once, "
                + "for the host the application renders on.");
        }

        var manager = new HeadManager();
        features.Set(manager);
        return manager;
    }
}
