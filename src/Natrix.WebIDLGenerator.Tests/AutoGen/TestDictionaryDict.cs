// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestDictionaryDict: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestDictionaryDict>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestDictionaryDict(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestDictionaryDict global::Natrix.JSCore.IJSObjectProxy<TestDictionaryDict>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestDictionaryDict(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Age
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "age");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "age", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "active");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "active", value);
    }
}

#nullable disable