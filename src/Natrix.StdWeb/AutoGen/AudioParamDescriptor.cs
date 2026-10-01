// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioParamDescriptor: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioParamDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioParamDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioParamDescriptor global::Natrix.JSCore.IJSObjectProxy<AudioParamDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioParamDescriptor(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DefaultValue
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "defaultValue");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "defaultValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MinValue
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "minValue");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "minValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MaxValue
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "maxValue");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "maxValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AutomationRate AutomationRate
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AutomationRate>.Get(JSObject, "automationRate");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AutomationRate>.Set(JSObject, "automationRate", value);
    }
}

#nullable disable