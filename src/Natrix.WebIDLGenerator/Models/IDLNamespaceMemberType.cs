using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ConstantMemberType), "const")]
[JsonDerivedType(typeof(AttributeMemberType), "attribute")]
[JsonDerivedType(typeof(OperationMemberType), "operation")]
public abstract record IDLNamespaceMemberType : IDLCallbackInterfaceMemberType
{
}