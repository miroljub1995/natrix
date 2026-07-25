// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TurboShakeParams: global::Natrix.StdWeb.Algorithm
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TurboShakeParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TurboShakeParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint OutputLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outputLength");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outputLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte DomainSeparation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainSeparation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainSeparation", value);
    }
}

#nullable disable