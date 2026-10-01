// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TagType: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TagType>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TagType(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TagType global::Natrix.JSCore.IJSObjectProxy<TagType>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TagType(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ValueType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>> Parameters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ValueType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ValueType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>>>>(JSObject, "parameters");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ValueType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ValueType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ValueType>>>>(JSObject, "parameters", value);
    }
}

#nullable disable