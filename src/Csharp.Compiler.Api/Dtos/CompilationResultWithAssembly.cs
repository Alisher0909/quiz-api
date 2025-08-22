namespace Csharp.Compiler.Api.Dtos;

public class CompilationResultWithAssembly
{
    public bool IsSuccess { get; set; }
    public List<string>? Errors { get; set; } = new();
    public Assembly? Assembly { get; set; }
}