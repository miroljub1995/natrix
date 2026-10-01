// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothManufacturerDataFilterInit: global::Natrix.StdWeb.BluetoothDataFilterInit, global::Natrix.JSCore.IJSObjectProxy<BluetoothManufacturerDataFilterInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothManufacturerDataFilterInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothManufacturerDataFilterInit global::Natrix.JSCore.IJSObjectProxy<BluetoothManufacturerDataFilterInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothManufacturerDataFilterInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort CompanyIdentifier
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "companyIdentifier");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "companyIdentifier", value);
    }
}

#nullable disable