// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CollectedClientPaymentData: global::Natrix.StdWeb.CollectedClientData
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientPaymentData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CollectedClientPaymentData(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData, global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData, global::Natrix.StdWeb.GenericMarshaller.Union> Payment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData, global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData, global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payment", value);
    }
}

#nullable disable