using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.GraphQL.Mutations.Payloads;

public record CreateUserPayload(User User);