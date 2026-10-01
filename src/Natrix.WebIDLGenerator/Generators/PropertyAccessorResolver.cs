using System.Diagnostics.CodeAnalysis;
using Natrix.WebIDLGenerator.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Natrix.WebIDLGenerator.Generators;

/// <summary>
/// Names the <c>IPropertyAccessor&lt;T&gt;</c> implementation for an IDL type. Every accessor is a
/// separate type in Natrix.JSCore (or the proxy type itself), so nothing is collected into one
/// shared class that would keep every marshalled type alive when trimming.
/// </summary>
public class PropertyAccessorResolver(
    IServiceProvider provider,
    GenTypeDescriptors descriptors
)
{
    private const string Ns = "global::Natrix.JSCore.Generics";

    public string Resolve(IDLTypeDescription input)
    {
        var nullablePrefix = input.Nullable ? "Nullable" : "";

        if (input is SingleTypeDescription single && TryResolvePrimitive(single.IdlType, out var primitive))
        {
            return $"{Ns}.{nullablePrefix}{primitive}Accessor";
        }

        var typeDeclaration = provider
            .GetRequiredService<IDLTypeDescriptionToTypeDeclarationGenerator>()
            .Generate(input with { Nullable = false });

        var kind = input switch
        {
            UnionTypeDescription => "Union",
            SingleTypeDescription { IdlType: var idlType } => ResolveSingleKind(idlType),
            FrozenArrayTypeDescription or
                ObservableArrayTypeDescription or
                PromiseTypeDescription or
                RecordTypeDescription or
                SequenceTypeDescription => "Proxy",
            _ => throw new NotSupportedException($"No property accessor for {input}."),
        };

        return $"{Ns}.{nullablePrefix}{kind}Accessor<{typeDeclaration}>";
    }

    private string ResolveSingleKind(string idlType)
    {
        if (!descriptors.TryGet(idlType, out var descriptor))
        {
            throw new NotSupportedException($"No property accessor for unknown type {idlType}.");
        }

        return descriptor.RootType switch
        {
            EnumType => "Enum",
            InterfaceType or CallbackType or CallbackInterfaceType or DictionaryType => "Proxy",
            _ => throw new NotSupportedException(
                $"No property accessor for {idlType} ({descriptor.RootType.GetType().Name})."),
        };
    }

    private static bool TryResolvePrimitive(string idlType, [NotNullWhen(true)] out string? name)
    {
        name = idlType switch
        {
            BuiltinTypes.Boolean => "Boolean",
            BuiltinTypes.Byte => "Byte",
            BuiltinTypes.SignedByte => "SByte",
            BuiltinTypes.Short => "Int16",
            BuiltinTypes.UnsignedShort => "UInt16",
            BuiltinTypes.Int32 => "Int32",
            BuiltinTypes.UnsignedInt32 => "UInt32",
            BuiltinTypes.Int64 => "Int64",
            BuiltinTypes.UnsignedInt64 => "UInt64",
            BuiltinTypes.Float or BuiltinTypes.UnrestrictedFloat => "Single",
            BuiltinTypes.Double or BuiltinTypes.UnrestrictedDouble => "Double",
            BuiltinTypes.BigInt => "BigInteger",
            BuiltinTypes.String => "String",
            BuiltinTypes.Object => "JSObject",
            BuiltinTypes.ManagedObject => "Object",
            _ => null,
        };

        return name is not null;
    }
}
