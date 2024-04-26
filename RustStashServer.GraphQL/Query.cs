using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;
using RustStashServer.Core;
using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.GraphQL;

[QueryType]
public class Query
{
    // [Authorize]
    public async Task<User> GetUser(AppDbContext dbContext)
    {
        var user = await dbContext.Users
            .Include(u => u.Username).FirstOrDefaultAsync();
        return user!;
    }
    
    public async Task<User> AddUser(AppDbContext dbContext)
    {
        var user = await dbContext.Users
            .Include(u => u.Username).FirstOrDefaultAsync();
        return user!;
    }
}