// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLEluOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLEluOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLEluOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLEluOptions global::Natrix.JSCore.IJSObjectProxy<MLEluOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLEluOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Alpha
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "alpha", value);
    }
}

#nullable disable