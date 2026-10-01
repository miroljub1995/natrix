// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConstrainULongRange: global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.IJSObjectProxy<ConstrainULongRange>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConstrainULongRange(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConstrainULongRange global::Natrix.JSCore.IJSObjectProxy<ConstrainULongRange>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConstrainULongRange(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Exact
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "exact");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "exact", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Ideal
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "ideal");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "ideal", value);
    }
}

#nullable disable