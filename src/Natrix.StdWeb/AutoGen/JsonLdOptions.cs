// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class JsonLdOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<JsonLdOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public JsonLdOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static JsonLdOptions global::Natrix.JSCore.IJSObjectProxy<JsonLdOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public JsonLdOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Base
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "base");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "base", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CompactArrays
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compactArrays");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compactArrays", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CompactToRelative
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compactToRelative");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compactToRelative", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LoadDocumentCallback? DocumentLoader
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.LoadDocumentCallback>.Get(JSObject, "documentLoader");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.LoadDocumentCallback>.Set(JSObject, "documentLoader", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>>, global::Natrix.JSCore.Generics.StringAccessor>? ExpandContext
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "expandContext");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "expandContext", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ExtractAllScripts
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "extractAllScripts");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "extractAllScripts", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FrameExpansion
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "frameExpansion");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "frameExpansion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Ordered
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ordered");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ordered", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ProcessingMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "processingMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "processingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ProduceGeneralizedRdf
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "produceGeneralizedRdf");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "produceGeneralizedRdf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? RdfDirection
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "rdfDirection");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "rdfDirection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UseNativeTypes
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "useNativeTypes");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "useNativeTypes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UseRdfType
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "useRdfType");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "useRdfType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.JsonLdEmbed, bool, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.JsonLdEmbed>, global::Natrix.JSCore.Generics.BooleanAccessor> Embed
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.JsonLdEmbed, bool, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.JsonLdEmbed>, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "embed");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.JsonLdEmbed, bool, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.JsonLdEmbed>, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "embed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Explicit
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "explicit");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "explicit", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool OmitDefault
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "omitDefault");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "omitDefault", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool OmitGraph
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "omitGraph");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "omitGraph", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequireAll
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requireAll");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requireAll", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FrameDefault
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "frameDefault");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "frameDefault", value);
    }
}

#nullable disable