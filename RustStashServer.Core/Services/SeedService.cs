using RustStashServer.Core.Entities;

namespace RustStashServer.Core.Services;

using Microsoft.AspNetCore.Identity;
using RustStashServer.Core.Entities.Auth;


public class SeedService
{
    public async Task Seed(
        AppDbContext dbContext,
        UserManager<User> userManager,
        IPasswordHasher<User> passwordHasher,
        RoleManager<Role> roleManager,
        UserService userService,
        string scenario)
    {
        await CreateUsers(dbContext, userManager, passwordHasher, scenario);
        await CreateRoles(dbContext, roleManager);
        await CreateCategories(dbContext);
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

        await dbContext.SaveChangesAsync();
    }

    private static async Task CreateRoles(AppDbContext dbContext, RoleManager<Role> roleManager)
    {
        var roles = new List<Role>
        {
            new()
            {
                Name = RoleEnum.User.ToString(),
            },
            new Role()
            {
                Name = RoleEnum.Admin.ToString(),
            },
        };
        foreach (var role in roles)
        {
            await roleManager.CreateAsync(role);
        }

        await dbContext.SaveChangesAsync();
    }

    private async Task CreateCategories(AppDbContext dbContext)
    {
        var categories = new List<Category>()
        {
            new()
            {
                CategoryId = 0,
                CategoryName = "Construction",
            },
            new()
            {
                CategoryId = 1,
                CategoryName = "Crafting",
            },
            new()
            {
                CategoryId = 2,
                CategoryName = "Food"
            },
            new()
            {
                CategoryId = 3,
                CategoryName = "Tools"
            },
            new()
            {
                CategoryId = 4,
                CategoryName = "Ammunition"
            },
            new()
            {
                CategoryId = 5,
                CategoryName = "Resources"
            },
        };

        foreach (var item in categories)
        {
            // TODO: add service method that adds categories
            // catService.AddCategory(){}
        }

        await dbContext.SaveChangesAsync();
    }

    private static async Task CreateMaterials(AppDbContext dbContext, MaterialService matService)
    {
        var materials = new List<Material>()
        {
            new()
            {
                MaterialId = 0,
                MaterialImage = null,
                MaterialDescription = null,
                MaterialCategories = new List<MaterialCategory>
                {
                    Capacity = 3
                },
                MaterialIsCraftable = false,
                RecipeMaterials = new List<RecipeMaterial>
                {
                    Capacity = 2
                },
                UserStashMaterials = new List<UserStashMaterial>
                {
                    Capacity = 1
                }
            }
        };

        await dbContext.SaveChangesAsync();
    }
}