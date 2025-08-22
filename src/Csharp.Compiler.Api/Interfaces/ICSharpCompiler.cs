namespace Csharp.Compiler.Api.Interfaces;

public interface ICSharpCompiler
{
     ValueTask<CompilationResult> CanCompileAsync(string code, CancellationToken cancellationToken = default);
     ValueTask<CompilationResultWithAssembly> CompileAsync(string code, CancellationToken cancellationToken = default);
     ValueTask<(CompilationResult Compilation, string Output)> ExecuteAsync(string code, string input, CancellationToken cancellationToken = default);
     ValueTask<(CompilationResult Compilation, List<string> Outputs)> ExecuteAsync(string code, List<string> inputs, CancellationToken cancellationToken = default);
}