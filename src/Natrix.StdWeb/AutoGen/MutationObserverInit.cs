// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MutationObserverInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MutationObserverInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MutationObserverInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MutationObserverInit global::Natrix.JSCore.IJSObjectProxy<MutationObserverInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MutationObserverInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ChildList
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "childList");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "childList", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Attributes
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "attributes");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "attributes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CharacterData
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "characterData");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "characterData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Subtree
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "subtree");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "subtree", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AttributeOldValue
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "attributeOldValue");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "attributeOldValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CharacterDataOldValue
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "characterDataOldValue");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "characterDataOldValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> AttributeFilter
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "attributeFilter");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "attributeFilter", value);
    }
}

#nullable disable