using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(AttributeMemberType), "attribute")]
[JsonDerivedType(typeof(ConstantMemberType), "const")]
[JsonDerivedType(typeof(OperationMemberType), "operation")]
public abstract record IDLInterfaceMixinMemberType : IDLNamespaceMemberType
{
}