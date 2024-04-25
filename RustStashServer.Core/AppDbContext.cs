using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.Core
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            this.SavingChanges += (_, args) =>
            {
                //var sessionContext = this.GetService<ISessionContext>
            };
        }

        // setting tables
        public DbSet<User> Users => this.Set<User>();


        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        //     builder.Entity<User>()
        //         .HasMany()
        // }
    }
}
