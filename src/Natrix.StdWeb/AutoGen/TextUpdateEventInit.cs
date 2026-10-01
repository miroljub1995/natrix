// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextUpdateEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<TextUpdateEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextUpdateEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextUpdateEventInit global::Natrix.JSCore.IJSObjectProxy<TextUpdateEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextUpdateEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UpdateRangeStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "updateRangeStart");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "updateRangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UpdateRangeEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "updateRangeEnd");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "updateRangeEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionStart");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "selectionStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionEnd");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "selectionEnd", value);
    }
}

#nullable disable