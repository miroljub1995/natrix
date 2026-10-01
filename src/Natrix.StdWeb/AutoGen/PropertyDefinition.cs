// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PropertyDefinition: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PropertyDefinition>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PropertyDefinition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PropertyDefinition global::Natrix.JSCore.IJSObjectProxy<PropertyDefinition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PropertyDefinition(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Syntax
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "syntax");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "syntax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool Inherits
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "inherits");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "inherits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InitialValue
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "initialValue");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "initialValue", value);
    }
}

#nullable disable