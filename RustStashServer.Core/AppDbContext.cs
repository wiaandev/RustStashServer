using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

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
    }
}
