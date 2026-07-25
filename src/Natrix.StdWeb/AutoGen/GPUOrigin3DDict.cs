// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUOrigin3DDict: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUOrigin3DDict(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUOrigin3DDict(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Z
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "z");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "z", value);
    }
}

#nullable disable