// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EventModifierInit: global::Natrix.StdWeb.UIEventInit, global::Natrix.JSCore.IJSObjectProxy<EventModifierInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventModifierInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EventModifierInit global::Natrix.JSCore.IJSObjectProxy<EventModifierInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EventModifierInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CtrlKey
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ctrlKey");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ctrlKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShiftKey
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "shiftKey");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "shiftKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AltKey
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "altKey");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "altKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MetaKey
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "metaKey");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "metaKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierAltGraph
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierAltGraph");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierAltGraph", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierCapsLock
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierCapsLock");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierCapsLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierFn
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierFn");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierFn", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierFnLock
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierFnLock");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierFnLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierHyper
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierHyper");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierHyper", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierNumLock
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierNumLock");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierNumLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierScrollLock
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierScrollLock");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierScrollLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierSuper
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierSuper");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierSuper", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierSymbol
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierSymbol");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierSymbol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ModifierSymbolLock
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "modifierSymbolLock");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "modifierSymbolLock", value);
    }
}

#nullable disable