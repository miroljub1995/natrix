// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CloseEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<CloseEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CloseEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CloseEventInit global::Natrix.JSCore.IJSObjectProxy<CloseEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CloseEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WasClean
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "wasClean");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "wasClean", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Code
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "code");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "code", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Reason
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "reason", value);
    }
}

#nullable disable