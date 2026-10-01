// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLCumulativeSumOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLCumulativeSumOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLCumulativeSumOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLCumulativeSumOptions global::Natrix.JSCore.IJSObjectProxy<MLCumulativeSumOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLCumulativeSumOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Exclusive
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "exclusive");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "exclusive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Reversed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "reversed");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "reversed", value);
    }
}

#nullable disable