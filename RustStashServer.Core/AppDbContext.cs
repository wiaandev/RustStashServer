using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RustStashServer.Core.Entities;
using RustStashServer.Core.Entities.Auth;


namespace RustStashServer.Core
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        // setting tables
        // public DbSet<User> Users => this.Set<User>();
        public DbSet<Base> Bases => this.Set<Base>();

        public DbSet<Category> Categories => this.Set<Category>();

        public DbSet<Material> Materials => this.Set<Material>();

        public DbSet<Recipe> Recipes => this.Set<Recipe>();

        public DbSet<RecipeIngredient> RecipeIngredients => this.Set<RecipeIngredient>();

        public DbSet<UserStash> UserStashes => this.Set<UserStash>();


        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        //     builder.Entity<Base>()
        //         .HasMany(UserStashes.)
        // }

        // protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        // {
        //     builder.Properties(typeof(Enum))
        //         .HaveConversion<string>();
        // }

    }
}
