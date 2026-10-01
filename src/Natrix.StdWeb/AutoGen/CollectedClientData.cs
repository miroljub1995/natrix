// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CollectedClientData: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CollectedClientData>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CollectedClientData global::Natrix.JSCore.IJSObjectProxy<CollectedClientData>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientData(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Challenge
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "challenge");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "challenge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TopOrigin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "topOrigin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "topOrigin", value);
    }
}

#nullable disable