// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLArgMinMaxOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLArgMinMaxOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLArgMinMaxOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLArgMinMaxOptions global::Natrix.JSCore.IJSObjectProxy<MLArgMinMaxOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLArgMinMaxOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepDimensions
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "keepDimensions");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "keepDimensions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperandDataType OutputDataType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>.Get(JSObject, "outputDataType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLOperandDataType>.Set(JSObject, "outputDataType", value);
    }
}

#nullable disable