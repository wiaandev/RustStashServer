using RustStashServer.Core;
using RustStashServer.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<RustStashDbContext>()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

// app.UseCors();

app.Run();