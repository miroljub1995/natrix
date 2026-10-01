// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DigitalGoodsService: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DigitalGoodsService>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DigitalGoodsService(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DigitalGoodsService global::Natrix.JSCore.IJSObjectProxy<DigitalGoodsService>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DigitalGoodsService>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>>> GetDetails(global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> itemIds)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = itemIds.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getDetails", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ItemDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ItemDetails>>>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>> ListPurchases()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "listPurchases", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>> ListPurchaseHistory()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "listPurchaseHistory", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PurchaseDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PurchaseDetails>>>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Consume(string purchaseToken)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = purchaseToken;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "consume", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Promise, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable