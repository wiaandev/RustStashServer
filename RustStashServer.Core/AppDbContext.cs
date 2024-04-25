using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RustStashServer.Core.Entities.Auth;


namespace RustStashServer.Core
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        // setting tables
        // public DbSet<User> Users => this.Set<User>();


        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        //     builder.Entity<User>()
        //         .HasMany()
        // }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties(typeof(Enum))
                .HaveConversion<string>();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
    }
}
