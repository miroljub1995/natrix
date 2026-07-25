// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechSynthesisEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.SpeechSynthesisUtterance Utterance
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SpeechSynthesisUtterance, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "utterance");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SpeechSynthesisUtterance, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "utterance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "charIndex");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "charIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "charLength");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "charLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float ElapsedTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "elapsedTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "elapsedTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name", value);
    }
}

#nullable disable