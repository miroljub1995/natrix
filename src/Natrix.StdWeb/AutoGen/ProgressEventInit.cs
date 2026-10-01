// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProgressEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<ProgressEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProgressEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProgressEventInit global::Natrix.JSCore.IJSObjectProxy<ProgressEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProgressEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool LengthComputable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "lengthComputable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "lengthComputable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Loaded
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loaded");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "loaded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Total
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "total");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "total", value);
    }
}

#nullable disable