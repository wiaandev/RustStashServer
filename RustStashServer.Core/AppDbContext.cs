namespace RustStashServer.Core;


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RustStashServer.Core.Entities;
using RustStashServer.Core.Entities.Auth;

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

        public DbSet<RecipeMaterial> RecipeIngredients => this.Set<RecipeMaterial>();

        public DbSet<UserStash> UserStashes => this.Set<UserStash>();

        public DbSet<UserStashMaterial> UserStashMaterials => this.Set<UserStashMaterial>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Base>()
                .HasOne<UserStash>(b => b.BaseUserStashId)
                .WithOne(us => us.Base)
                .HasForeignKey<UserStash>(us => us.UserStashId);

            builder.Entity<MaterialCategory>().HasKey(mc => new { mc.MaterialIds, mc.CategoryIds });

            builder.Entity<MaterialCategory>()
                .HasOne<Category>()
                .WithMany(c => c.MaterialCategories)
                .HasForeignKey(cm => cm.CategoryIds);

            builder.Entity<MaterialCategory>()
                .HasOne<Material>()
                .WithMany(c => c.MaterialCategories)
                .HasForeignKey(cm => cm.MaterialIds);

            builder.Entity<RecipeMaterial>().HasKey(ri => new { ri.RecipeIds, ri.MaterialIds });

            builder.Entity<RecipeMaterial>()
                .HasOne<Recipe>()
                .WithMany(ri => ri.RecipeMaterials)
                .HasForeignKey(ri => ri.RecipeIds);

            builder.Entity<RecipeMaterial>()
                .HasOne<Material>()
                .WithMany(ri => ri.RecipeMaterials)
                .HasForeignKey(ri => ri.MaterialIds);

            builder.Entity<UserStashMaterial>().HasKey(um => new { um.UserStashIds, um.MaterialIds });

            builder.Entity<UserStashMaterial>()
                .HasOne<UserStash>()
                .WithMany(um => um.UserStashMaterials)
                .HasForeignKey(um => um.UserStashIds);

            builder.Entity<UserStashMaterial>()
                .HasOne<Material>()
                .WithMany(um => um.UserStashMaterials)
                .HasForeignKey(um => um.MaterialIds);

        }

        // protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        // {
        //     builder.Properties(typeof(Enum))
        //         .HaveConversion<string>();
        // }

    }
