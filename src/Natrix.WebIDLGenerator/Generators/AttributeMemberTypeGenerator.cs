using Natrix.WebIDLGenerator.Extensions;
using Natrix.WebIDLGenerator.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Natrix.WebIDLGenerator.Generators;

public class AttributeMemberTypeGenerator(
    IServiceProvider provider
)
{
    public string Generate(AttributeMemberType input, AbstractContainer container)
    {
        var descriptionToTypeDeclarationGenerator =
            provider.GetRequiredService<IDLTypeDescriptionToTypeDeclarationGenerator>();
        var propertyAccessorGenerator = provider.GetRequiredService<PropertyAccessorGenerator>();

        List<string> bodyParts = [];

        var isStatic = input.Special == AttributeSpecial.Static;
        var staticKeyword = isStatic ? " static" : "";

        var name = GetValidPropertyName(input.Name, container.Name);

        var returnTypeDeclaration = descriptionToTypeDeclarationGenerator.Generate(input.IdlType);

        var accessor = propertyAccessorGenerator.GetOrCreateAccessor(input.IdlType);

        // Getter
        {
            var inputVar = isStatic
                ? "global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy" +
                  $"(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, \"{container.Name}\")"
                : "JSObject";

            var getter = $$"""
                           get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<{{returnTypeDeclaration}}, {{accessor}}>({{inputVar}}, "{{input.Name}}");
                           """;

            bodyParts.Add(getter);
        }

        // Setter
        if (!input.Readonly)
        {
            var inputVar = isStatic
                ? "global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy" +
                  $"(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, \"{container.Name}\")"
                : "JSObject";

            var setter = $$"""
                           set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<{{returnTypeDeclaration}}, {{accessor}}>({{inputVar}}, "{{input.Name}}", value);
                           """;

            bodyParts.Add(setter);
        }

        var body = string.Join("\n", bodyParts);

        var content = $$"""
                        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
                        public{{staticKeyword}} {{returnTypeDeclaration}} {{name}}
                        {
                        {{body.IndentLines(4)}}
                        }
                        """;

        return content;
    }

    private static string GetValidPropertyName(string name, string containingTypeName)
    {
        name = name.Replace('-', '_').CapitalizeFirstLetter();
        if (name == containingTypeName)
        {
            name += "_";
        }

        return name;
    }
}