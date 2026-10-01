using Natrix.WebIDLGenerator.Extensions;
using Natrix.WebIDLGenerator.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Natrix.WebIDLGenerator.Generators;

public class InterfaceTypeGenerator(
    IServiceProvider provider,
    GenSettings genSettings,
    GenTypeDescriptors descriptors
)
{
    public string Generate(InterfaceType input)
    {
        var memberTypeGenerator = provider.GetRequiredService<MemberTypeGenerator>();

        var baseTypeName = GetInheritance(input);

        List<string> bodyParts = [];

        foreach (var idlInterfaceMemberType in input.Members)
        {
            var part = memberTypeGenerator.Generate(idlInterfaceMemberType, input);
            if (!string.IsNullOrEmpty(part))
            {
                bodyParts.Add(part);
            }
        }

        var body = string.Join("\n\n", bodyParts);

        var content = $$"""
                        // ReSharper disable All

                        namespace {{genSettings.Namespace}};

                        #nullable enable

                        public partial class {{input.Name}}: {{baseTypeName}}, global::Natrix.JSCore.IJSObjectProxy<{{input.Name}}>
                        {
                            [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
                            public {{input.Name}}(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
                            {
                            }

                            [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
                            static {{input.Name}} global::Natrix.JSCore.IJSObjectProxy<{{input.Name}}>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
                                global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<{{input.Name}}>(obj);

                        {{body.IndentLines(4)}}
                        }

                        #nullable disable
                        """;

        return content;
    }

    private string GetInheritance(InterfaceType input)
    {
        if (input.Inheritance is null)
        {
            return "global::Natrix.JSCore.JSObjectProxy";
        }

        var desc = descriptors.GetRequired(input.Inheritance);
        return $"global::{desc.Namespace}.{desc.Name}";
    }
}