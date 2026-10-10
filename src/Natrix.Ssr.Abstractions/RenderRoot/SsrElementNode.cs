using System.IO.Pipelines;
using System.Text;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public sealed class SsrElementNode : ISsrNode
{
    private readonly List<(string Name, object Value, Func<object, SsrAttributeValue?> Selector)> _attributes = [];
    private readonly List<(object Value, Func<object, IEnumerable<(string Name, SsrAttributeValue? Value)>> Selector)> _multiAttributes = [];

    public required string TagName { get; init; }

    public bool IsVoid { get; init; }

    public ISsrRenderRoot? ChildRoot { get; set; }

    /// <summary>
    /// Sets the attribute <paramref name="name"/>, replacing an earlier one of the same name.
    /// </summary>
    /// <param name="value">State handed to <paramref name="selector"/>, usually a signal.</param>
    /// <param name="selector">Computes the attribute when the page is written; <c>null</c> omits it.</param>
    public void SetAttribute(string name, object value, Func<object, SsrAttributeValue?> selector)
    {
        var index = _attributes.FindIndex(a => a.Name == name);
        if (index >= 0)
        {
            _attributes[index] = (name, value, selector);
        }
        else
        {
            _attributes.Add((name, value, selector));
        }
    }

    /// <summary>
    /// The current value of the attribute <paramref name="name"/> set with
    /// <see cref="SetAttribute"/>, or <c>null</c> when it is absent.
    /// </summary>
    public SsrAttributeValue? GetAttribute(string name)
    {
        foreach (var (attributeName, value, selector) in _attributes)
        {
            if (attributeName == name)
            {
                return selector(value);
            }
        }

        return null;
    }

    public IEnumerable<ISsrNode> GetChildNodes() => ChildRoot?.GetNodes() ?? [];

    public void SetMultiAttribute(object value, Func<object, IEnumerable<(string Name, SsrAttributeValue? Value)>> selector)
        => _multiAttributes.Add((value, selector));

    public async ValueTask WriteAsync(PipeWriter writer, bool sortAttributes, CancellationToken cancellationToken = default)
    {
        Write(writer, "<");
        Write(writer, TagName);

        var pairs = sortAttributes
            ? GetAllAttributePairs().OrderBy(static p => p.Name, StringComparer.Ordinal)
            : GetAllAttributePairs();

        foreach (var (name, attrValue) in pairs)
        {
            WriteAttribute(writer, name, attrValue.Value);
        }

        Write(writer, ">");

        if (!IsVoid)
        {
            if (ChildRoot is not null)
            {
                await ChildRoot.WriteAsync(writer, sortAttributes, cancellationToken).ConfigureAwait(false);
            }

            Write(writer, "</");
            Write(writer, TagName);
            Write(writer, ">");
        }

        if (writer.CanGetUnflushedBytes && writer.UnflushedBytes >= 8 * 1024)
        {
            await writer.FlushAsync(cancellationToken).ConfigureAwait(false);
        }
    }

    private IEnumerable<(string Name, SsrAttributeValue Value)> GetAllAttributePairs()
    {
        foreach (var (name, value, selector) in _attributes)
        {
            if (selector(value) is { } v)
            {
                yield return (name, v);
            }
        }

        foreach (var (value, selector) in _multiAttributes)
        {
            foreach (var (name, attrValue) in selector(value))
            {
                if (attrValue is { } v)
                {
                    yield return (name, v);
                }
            }
        }
    }

    private static void Write(PipeWriter writer, string text) => Encoding.UTF8.GetBytes(text, writer);

    private static void WriteAttribute(PipeWriter writer, string name, string? value)
    {
        Write(writer, " ");
        Write(writer, name);
        if (value is not null)
        {
            Write(writer, "=\"");
            SsrHtmlEncoder.WriteEscaped(writer, value, escapeQuotes: true);
            Write(writer, "\"");
        }
    }
}
