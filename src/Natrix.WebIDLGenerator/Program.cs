using System.CommandLine;
using System.Text.Json;
using Natrix.WebIDLGenerator.Commands;
using Natrix.WebIDLGenerator.Models;



RootCommand rootCommand = new("WebIDL Generator");
rootCommand.Subcommands.Add(new GenerateCommand());

return await rootCommand.Parse(args).InvokeAsync();