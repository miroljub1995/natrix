// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GlobalDescriptor: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GlobalDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GlobalDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GlobalDescriptor global::Natrix.JSCore.IJSObjectProxy<GlobalDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GlobalDescriptor(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.ValueType Value
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Mutable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mutable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "mutable", value);
    }
}

#nullable disable