using Csharp.Compiler.Sdk;
using Csharp.Compiler.Api.Dtos;
using Csharp.Compiler.Api.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/compile", async (CompileRequest req) =>
{
    ICSharpCompiler compiler = new DemoCompiler();
    var result = await compiler.CompileAsync(req.Code);
    return Results.Ok(result);
});

app.MapPost("/execute-single-input", async (ExecuteSingleInputRequest req) =>
{
    ICSharpCompiler compiler = new DemoCompiler();
    var result = await compiler.ExecuteAsync(req.Code, req.Input);
    return Results.Ok(result);
});

app.MapPost("/execute-multiple-inputs", async (ExecuteMultipleInputsRequest req) =>
{
    ICSharpCompiler compiler = new DemoCompiler();
    var result = await compiler.ExecuteAsync(req.Code, req.Inputs);
    return Results.Ok(result);
});

app.Run();