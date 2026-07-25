// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate global::Natrix.JSCore.Promise NavigationInterceptHandlerManaged();

public partial class NavigationInterceptHandler: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptHandler(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptHandler(NavigationInterceptHandlerManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator NavigationInterceptHandler(NavigationInterceptHandlerManaged input)
    {
        return new global::Natrix.StdWeb.NavigationInterceptHandler(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.NavigationInterceptHandlerManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.NavigationInterceptHandlerManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = () =>
        {


            using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunction(JSObject, null, ___resOwner_1.JSObject);

            // Return Value
            global::Natrix.JSCore.Promise ___res_2;
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3;
            ___propObject_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___resOwner_1.JSObject, "value");
            ___res_2 = new global::Natrix.JSCore.Promise(___propObject_3);
            return ___res_2;
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(NavigationInterceptHandlerManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject, global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0, ___res_3) =>
        {
            using (___args_0)
            using (___res_3)
            {


                global::Natrix.JSCore.Promise ___managedRes_4 = input();

                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___managedRes_4.JSObject;
                global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___res_3, "value", ___propObject_5);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_2 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsNonVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_2, input); 

        return ___funcObj_2;
    }
}

#nullable disable