using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;
using RustStashServer.Core;
using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.GraphQL;

[QueryType]
public class Query
{
    // [Authorize]
    public async Task<User> GetUser(RustStashDbContext dbContext)
    {
        var user = await dbContext.Users
            .Include(u => u.Username).FirstOrDefaultAsync();
        return user!;
    }
    
    public async Task<User> AddUser(RustStashDbContext dbContext)
    {
        var user = await dbContext.Users
            .Include(u => u.Username).FirstOrDefaultAsync();
        return user!;
    }
}