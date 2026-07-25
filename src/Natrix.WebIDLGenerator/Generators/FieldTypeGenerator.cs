using Natrix.WebIDLGenerator.Extensions;
using Natrix.WebIDLGenerator.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Natrix.WebIDLGenerator.Generators;

public class FieldTypeGenerator(
    IServiceProvider provider
)
{
    public string Generate(FieldType input)
    {
        var descriptionToTypeDeclarationGenerator =
            provider.GetRequiredService<IDLTypeDescriptionToTypeDeclarationGenerator>();
        var propertyAccessorGenerator = provider.GetRequiredService<PropertyAccessorGenerator>();

        var requiredKeyword = input.Required ? " required" : "";
        var returnTypeDeclaration = descriptionToTypeDeclarationGenerator.Generate(input.IdlType);

        var accessor = propertyAccessorGenerator.GetOrCreateAccessor(input.IdlType);

        var getter = $$"""
                       get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<{{returnTypeDeclaration}}, {{accessor}}>(JSObject, "{{input.Name}}");
                       """;

        var setter = $$"""
                       set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<{{returnTypeDeclaration}}, {{accessor}}>(JSObject, "{{input.Name}}", value);
                       """;

        var content = $$"""
                        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
                        public{{requiredKeyword}} {{returnTypeDeclaration}} {{input.Name.CapitalizeFirstLetter()}}
                        {
                        {{getter.IndentLines(4)}}
                        {{setter.IndentLines(4)}}
                        }
                        """;

        return content;
    }
}