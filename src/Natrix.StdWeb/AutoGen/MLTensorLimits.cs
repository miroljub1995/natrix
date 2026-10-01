// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLTensorLimits: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLTensorLimits>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTensorLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLTensorLimits global::Natrix.JSCore.IJSObjectProxy<MLTensorLimits>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTensorLimits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLOperandDataType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>> DataTypes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLOperandDataType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>>>.Get(JSObject, "dataTypes");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLOperandDataType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>>>.Set(JSObject, "dataTypes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLRankRange RankRange
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLRankRange>.Get(JSObject, "rankRange");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLRankRange>.Set(JSObject, "rankRange", value);
    }
}

#nullable disable