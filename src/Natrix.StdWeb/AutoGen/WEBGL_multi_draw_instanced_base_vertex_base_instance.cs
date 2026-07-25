// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_multi_draw_instanced_base_vertex_base_instance: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_multi_draw_instanced_base_vertex_base_instance(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void MultiDrawArraysInstancedBaseInstanceWEBGL(uint mode, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> firstsList, ulong firstsOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> countsList, ulong countsOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> instanceCountsList, ulong instanceCountsOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> baseInstancesList, ulong baseInstancesOffset, int drawcount)
    {
        int ___argsArrayLength_2 = 10;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(mode);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = firstsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        // Argument 3
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(firstsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = countsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 3, ___propObject_6);

        // Argument 5
        double ___marshalledValue_7;
        ___marshalledValue_7 = Convert.ToDouble(countsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_7);

        // Argument 6
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_8 = instanceCountsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 5, ___propObject_8);

        // Argument 7
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(instanceCountsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_9);

        // Argument 8
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_10 = baseInstancesList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 7, ___propObject_10);

        // Argument 9
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(baseInstancesOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_11);

        // Argument 10
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(drawcount);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 9, ___marshalledValue_12);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "multiDrawArraysInstancedBaseInstanceWEBGL", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void MultiDrawElementsInstancedBaseVertexBaseInstanceWEBGL(uint mode, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> countsList, ulong countsOffset, uint type, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> offsetsList, ulong offsetsOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> instanceCountsList, ulong instanceCountsOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> baseVerticesList, ulong baseVerticesOffset, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> baseInstancesList, ulong baseInstancesOffset, int drawcount)
    {
        int ___argsArrayLength_2 = 13;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(mode);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = countsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        // Argument 3
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(countsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        double ___marshalledValue_6;
        ___marshalledValue_6 = Convert.ToDouble(type);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_7 = offsetsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 4, ___propObject_7);

        // Argument 6
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(offsetsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_8);

        // Argument 7
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_9 = instanceCountsList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 6, ___propObject_9);

        // Argument 8
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(instanceCountsOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_10);

        // Argument 9
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_11 = baseVerticesList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 8, ___propObject_11);

        // Argument 10
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(baseVerticesOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 9, ___marshalledValue_12);

        // Argument 11
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_13 = baseInstancesList.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 10, ___propObject_13);

        // Argument 12
        double ___marshalledValue_14;
        ___marshalledValue_14 = Convert.ToDouble(baseInstancesOffset);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 11, ___marshalledValue_14);

        // Argument 13
        double ___marshalledValue_15;
        ___marshalledValue_15 = Convert.ToDouble(drawcount);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 12, ___marshalledValue_15);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "multiDrawElementsInstancedBaseVertexBaseInstanceWEBGL", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable