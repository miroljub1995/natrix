// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLGemmOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLGemmOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLGemmOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLGemmOptions global::Natrix.JSCore.IJSObjectProxy<MLGemmOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLGemmOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLOperand C
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Get(JSObject, "c");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLOperand>.Set(JSObject, "c", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Alpha
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Beta
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "beta");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "beta", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ATranspose
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "aTranspose");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "aTranspose", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BTranspose
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "bTranspose");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "bTranspose", value);
    }
}

#nullable disable