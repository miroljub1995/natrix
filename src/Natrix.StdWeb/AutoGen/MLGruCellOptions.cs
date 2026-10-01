// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLGruCellOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLGruCellOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLGruCellOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLGruCellOptions global::Natrix.JSCore.IJSObjectProxy<MLGruCellOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLGruCellOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperand Bias
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Get(JSObject, "bias");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Set(JSObject, "bias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperand RecurrentBias
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Get(JSObject, "recurrentBias");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Set(JSObject, "recurrentBias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ResetAfter
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "resetAfter");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "resetAfter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLGruWeightLayout Layout
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLGruWeightLayout>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLGruWeightLayout>.Set(JSObject, "layout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLRecurrentNetworkActivation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLRecurrentNetworkActivation>> Activations
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLRecurrentNetworkActivation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLRecurrentNetworkActivation>>>.Get(JSObject, "activations");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MLRecurrentNetworkActivation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLRecurrentNetworkActivation>>>.Set(JSObject, "activations", value);
    }
}

#nullable disable