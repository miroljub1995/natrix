// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EditContextInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EditContextInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EditContextInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EditContextInit global::Natrix.JSCore.IJSObjectProxy<EditContextInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EditContextInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
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