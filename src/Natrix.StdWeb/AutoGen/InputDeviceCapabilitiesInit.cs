// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InputDeviceCapabilitiesInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<InputDeviceCapabilitiesInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputDeviceCapabilitiesInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InputDeviceCapabilitiesInit global::Natrix.JSCore.IJSObjectProxy<InputDeviceCapabilitiesInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputDeviceCapabilitiesInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FiresTouchEvents
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "firesTouchEvents");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "firesTouchEvents", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PointerMovementScrolls
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "pointerMovementScrolls");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "pointerMovementScrolls", value);
    }
}

#nullable disable