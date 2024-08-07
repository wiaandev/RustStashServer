namespace RustStashServer.GraphQL.Mutations;

using HotChocolate.Authorization;
using RustStashServer.Core;
using RustStashServer.Core.Services;
using RustStashServer.Core.Services.Inputs;
using RustStashServer.GraphQL.Mutations.Payloads;

[MutationType]
public class UserMutations
{
    [Authorize(Roles = new[] { "Admin", "User" })]
    public async Task<CreateUserPayload> CreateUserMutation(
        RustStashDbContext dbContext,
        [Service] UserService userService,
        CreateUserInput input)
    {
        var user = await userService.Create(dbContext, input);

        return new CreateUserPayload(user);
    }
}