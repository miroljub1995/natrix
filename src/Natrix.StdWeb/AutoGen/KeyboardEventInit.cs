// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KeyboardEventInit: global::Natrix.StdWeb.EventModifierInit, global::Natrix.JSCore.IJSObjectProxy<KeyboardEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyboardEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static KeyboardEventInit global::Natrix.JSCore.IJSObjectProxy<KeyboardEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KeyboardEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Key
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "key");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "key", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Code
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "code");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "code", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Location
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "location");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "location", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Repeat
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "repeat");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "repeat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsComposing
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isComposing");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isComposing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharCode
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "charCode");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "charCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint KeyCode
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "keyCode");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "keyCode", value);
    }
}

#nullable disable