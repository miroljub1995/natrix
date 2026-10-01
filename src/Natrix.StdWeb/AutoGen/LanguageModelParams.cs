// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelParams: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelParams>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelParams global::Natrix.JSCore.IJSObjectProxy<LanguageModelParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LanguageModelParams>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DefaultTopK
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "defaultTopK");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxTopK
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "maxTopK");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DefaultTemperature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "defaultTemperature");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float MaxTemperature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "maxTemperature");
    }
}

#nullable disable