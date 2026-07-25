// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelParams: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DefaultTopK
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "defaultTopK");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTopK
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxTopK");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DefaultTemperature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "defaultTemperature");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MaxTemperature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxTemperature");
    }
}

#nullable disable