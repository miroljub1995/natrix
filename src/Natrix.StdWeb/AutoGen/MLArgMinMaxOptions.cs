// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLArgMinMaxOptions: global::Natrix.StdWeb.MLOperatorOptions
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLArgMinMaxOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLArgMinMaxOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepDimensions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keepDimensions");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keepDimensions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperandDataType OutputDataType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLOperandDataType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outputDataType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLOperandDataType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outputDataType", value);
    }
}

#nullable disable