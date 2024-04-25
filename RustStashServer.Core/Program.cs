using RustStashServer.Core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDb(builder.Configuration);

app.MapGet("/", () => "Hello World!");

app.Run();
