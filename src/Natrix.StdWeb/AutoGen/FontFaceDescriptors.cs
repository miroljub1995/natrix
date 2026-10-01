// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FontFaceDescriptors: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FontFaceDescriptors>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceDescriptors(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FontFaceDescriptors global::Natrix.JSCore.IJSObjectProxy<FontFaceDescriptors>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceDescriptors(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Style
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "style");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "style", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Weight
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "weight");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "weight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Stretch
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "stretch");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "stretch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UnicodeRange
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "unicodeRange");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "unicodeRange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FeatureSettings
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "featureSettings");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "featureSettings", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string VariationSettings
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "variationSettings");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "variationSettings", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Display
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "display");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "display", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AscentOverride
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "ascentOverride");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "ascentOverride", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DescentOverride
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "descentOverride");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "descentOverride", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LineGapOverride
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lineGapOverride");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lineGapOverride", value);
    }
}

#nullable disable