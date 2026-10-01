// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ShadowRootInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ShadowRootInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ShadowRootInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ShadowRootInit global::Natrix.JSCore.IJSObjectProxy<ShadowRootInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ShadowRootInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.ShadowRootMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ShadowRootMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ShadowRootMode>.Set(JSObject, "mode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DelegatesFocus
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "delegatesFocus");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "delegatesFocus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SlotAssignmentMode SlotAssignment
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SlotAssignmentMode>.Get(JSObject, "slotAssignment");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SlotAssignmentMode>.Set(JSObject, "slotAssignment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Clonable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "clonable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "clonable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Serializable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "serializable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "serializable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CustomElementRegistry? CustomElementRegistry
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CustomElementRegistry>.Get(JSObject, "customElementRegistry");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CustomElementRegistry>.Set(JSObject, "customElementRegistry", value);
    }
}

#nullable disable