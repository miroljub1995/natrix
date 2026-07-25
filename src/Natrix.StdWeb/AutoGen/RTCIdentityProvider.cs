// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIdentityProvider: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityProvider(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityProvider(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GenerateAssertionCallback GenerateAssertion
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GenerateAssertionCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "generateAssertion");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GenerateAssertionCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "generateAssertion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.ValidateAssertionCallback ValidateAssertion
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ValidateAssertionCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "validateAssertion");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ValidateAssertionCallback, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "validateAssertion", value);
    }
}

#nullable disable