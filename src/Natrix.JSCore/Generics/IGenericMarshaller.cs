using System.Runtime.InteropServices.JavaScript;

namespace Natrix.JSCore.Generics;

public interface IGenericMarshaller<T>
{
    static abstract T ToManaged(JSObject obj);
    static abstract JSObject ToJS(T obj);
}