// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioParamDescriptor: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioParamDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioParamDescriptor(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DefaultValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "defaultValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "defaultValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MinValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MaxValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AutomationRate AutomationRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AutomationRate, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "automationRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AutomationRate, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "automationRate", value);
    }
}

#nullable disable