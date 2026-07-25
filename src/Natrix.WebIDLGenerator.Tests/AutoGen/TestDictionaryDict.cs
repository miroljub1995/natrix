// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestDictionaryDict: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestDictionaryDict(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestDictionaryDict(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Age
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "age");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "age", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "active");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "active", value);
    }
}

#nullable disable