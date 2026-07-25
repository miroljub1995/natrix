// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate void VoidFunctionManaged();

public partial class VoidFunction: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VoidFunction(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VoidFunction(VoidFunctionManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator VoidFunction(VoidFunctionManaged input)
    {
        return new global::Natrix.StdWeb.VoidFunction(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.VoidFunctionManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.VoidFunctionManaged;
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


            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunction(JSObject, null);
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(VoidFunctionManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0) =>
        {
            using (___args_0)
            {


                input();
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_2 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_2, input);

        return ___funcObj_2;
    }
}

#nullable disable