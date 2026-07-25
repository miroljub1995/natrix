// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestCallbackInterfaceCallback: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackInterfaceCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackInterfaceCallback(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackInterfaceCallback(global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback input): this()
    {
        ProcessValue = input;
    }

    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestCallbackInterfaceCallback(global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallbackManaged input): this()
    {
        ProcessValue = input;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator TestCallbackInterfaceCallback(TestCallbackInterfaceCallbackCallback input)
    {
        return new global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallback(input);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator TestCallbackInterfaceCallback(TestCallbackInterfaceCallbackCallbackManaged input)
    {
        return new global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallback(input);
    }

    public const string EXPECTED_RESULT = "Processed: 999";

    public const int EXPECTED_VALUE = 999;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback ProcessValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "processValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.WebIDLGenerator.Tests.TestCallbackInterfaceCallbackCallback, global::Natrix.WebIDLGenerator.Tests.PropertyAccessor>(JSObject, "processValue", value);
    }
}

#nullable disable