// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUPrimitiveState: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPrimitiveState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPrimitiveState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUPrimitiveTopology Topology
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUPrimitiveTopology, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "topology");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUPrimitiveTopology, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "topology", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUIndexFormat StripIndexFormat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUIndexFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "stripIndexFormat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUIndexFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "stripIndexFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFrontFace FrontFace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFrontFace, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "frontFace");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFrontFace, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "frontFace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCullMode CullMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUCullMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cullMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUCullMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cullMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UnclippedDepth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unclippedDepth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unclippedDepth", value);
    }
}

#nullable disable