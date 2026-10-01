// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLSplitOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLSplitOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLSplitOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLSplitOptions global::Natrix.JSCore.IJSObjectProxy<MLSplitOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLSplitOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Axis
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "axis");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "axis", value);
    }
}

#nullable disable