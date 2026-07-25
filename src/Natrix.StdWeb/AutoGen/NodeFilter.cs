// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NodeFilter: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NodeFilter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NodeFilter(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NodeFilter(global::Natrix.StdWeb.NodeFilterCallback input): this()
    {
        AcceptNode = input;
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NodeFilter(global::Natrix.StdWeb.NodeFilterCallbackManaged input): this()
    {
        AcceptNode = input;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator NodeFilter(NodeFilterCallback input)
    {
        return new global::Natrix.StdWeb.NodeFilter(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator NodeFilter(NodeFilterCallbackManaged input)
    {
        return new global::Natrix.StdWeb.NodeFilter(input);
    }

    public const ushort FILTER_ACCEPT = 1;

    public const ushort FILTER_REJECT = 2;

    public const ushort FILTER_SKIP = 3;

    public const uint SHOW_ALL = 0xFFFFFFFF;

    public const uint SHOW_ELEMENT = 0x1;

    public const uint SHOW_ATTRIBUTE = 0x2;

    public const uint SHOW_TEXT = 0x4;

    public const uint SHOW_CDATA_SECTION = 0x8;

    public const uint SHOW_ENTITY_REFERENCE = 0x10;

    public const uint SHOW_ENTITY = 0x20;

    public const uint SHOW_PROCESSING_INSTRUCTION = 0x40;

    public const uint SHOW_COMMENT = 0x80;

    public const uint SHOW_DOCUMENT = 0x100;

    public const uint SHOW_DOCUMENT_TYPE = 0x200;

    public const uint SHOW_DOCUMENT_FRAGMENT = 0x400;

    public const uint SHOW_NOTATION = 0x800;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.NodeFilterCallback AcceptNode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NodeFilterCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "acceptNode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NodeFilterCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "acceptNode", value);
    }
}

#nullable disable