// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AssignedNodesOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AssignedNodesOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AssignedNodesOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AssignedNodesOptions global::Natrix.JSCore.IJSObjectProxy<AssignedNodesOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AssignedNodesOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Flatten
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "flatten");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "flatten", value);
    }
}

#nullable disable