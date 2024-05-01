using Microsoft.AspNetCore.Identity;
using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.Core.Services;

public class SeedService
{
    public async Task Seed(
        AppDbContext dbContext,
        UserManager<User> userManager,
        IPasswordHasher<User> passwordHasher,
        UserService userService,
        string scenario)
    {
        await CreateUsers(dbContext, userManager, passwordHasher, scenario);
    }

    private static async Task CreateUsers(
        AppDbContext dbContext,
        UserManager<User> userManager,
        IPasswordHasher<User> passwordHasher,
        string scenario)
    {
        var devUsers = new List<User>()
        {
            new()
            {
                UserName = "ezpionage",
                Id = 0,
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null!, "12345"),
                UserId = 0,
                Username = "ezpionage",
                Email = "wiaan@gmail.com",
                UserImage = "https://picsum.photos/200/300",
                CreatedAt = DateTime.Now,
                DateOfBirth = new DateOnly(2000, 6, 16),
            },
            new()
            {
                UserName = "charleneFerreira",
                Id = 1,
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null!, "12345"),
                UserId = 1,
                Username = "charleneFerreira",
                Email = "charlene@gmail.com",
                UserImage = "https://picsum.photos/200/300",
                CreatedAt = DateTime.Now,
                DateOfBirth = new DateOnly(2001, 5, 6),
            },
        };
    }
    
}