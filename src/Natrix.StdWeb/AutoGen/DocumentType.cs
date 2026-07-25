// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DocumentType: global::Natrix.StdWeb.Node
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentType(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PublicId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SystemId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "systemId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Before(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "before", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void After(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "after", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ReplaceWith(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "replaceWith", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "remove", JSObject);
    }
}

#nullable disable