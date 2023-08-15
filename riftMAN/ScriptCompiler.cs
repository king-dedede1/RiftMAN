using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace riftMAN.Mods;

// This is a mess and I'm sorry
internal class ScriptCompiler
{
    public static Script Compile(string source, string className)
    {
        var syntaxTree = SyntaxFactory.ParseSyntaxTree($"{header}{source}");
        var compilation = CSharpCompilation.Create("Script", new SyntaxTree[] { syntaxTree },
            references: refAssemblyNames.Select(name => MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName(name)).Location))
            .Append(MetadataReference.CreateFromFile(typeof(object).Assembly.Location)),
            options: defaultOptions);
        var stream = new MemoryStream();
        var emitResult = compilation.Emit(stream);
        if (!emitResult.Success)
        {
            throw new Exception($"Could not compile script {className}");
        }
        stream.Seek(0, SeekOrigin.Begin);
        Assembly assembly = Assembly.Load(stream.ToArray());
        stream.Dispose();
        Type sClass = assembly.GetType(className);
        return Activator.CreateInstance(sClass) as Script;
    }

    private static string[] refAssemblyNames = new[]
    {
        "System",
        "System.Runtime",
        "System.Core",
        "System.Data",
        "System.Data.DataSetExtensions",
        "System.Drawing",
        "System.Windows.Forms",
        "System.Xml",
        "System.Xml.Linq",
        "Microsoft.CSharp",
        "riftMAN"
    };

    private static string header = "using riftMAN;\nusing riftMAN.Mods;\n\n";

    private static CSharpCompilationOptions defaultOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

}
