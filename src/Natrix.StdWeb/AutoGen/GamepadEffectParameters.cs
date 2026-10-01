// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GamepadEffectParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GamepadEffectParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadEffectParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GamepadEffectParameters global::Natrix.JSCore.IJSObjectProxy<GamepadEffectParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GamepadEffectParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Duration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "duration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "duration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong StartDelay
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "startDelay");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "startDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double StrongMagnitude
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "strongMagnitude");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "strongMagnitude", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WeakMagnitude
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "weakMagnitude");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "weakMagnitude", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LeftTrigger
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "leftTrigger");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "leftTrigger", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RightTrigger
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "rightTrigger");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "rightTrigger", value);
    }
}

#nullable disable