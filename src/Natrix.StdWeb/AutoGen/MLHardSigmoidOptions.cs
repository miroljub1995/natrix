// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLHardSigmoidOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLHardSigmoidOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLHardSigmoidOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLHardSigmoidOptions global::Natrix.JSCore.IJSObjectProxy<MLHardSigmoidOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLHardSigmoidOptions(): base()
    {
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
}

#nullable disable