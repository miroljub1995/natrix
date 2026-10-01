// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLTriangularOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLTriangularOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTriangularOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLTriangularOptions global::Natrix.JSCore.IJSObjectProxy<MLTriangularOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTriangularOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Upper
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "upper");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "upper", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Diagonal
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "diagonal");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "diagonal", value);
    }
}

#nullable disable