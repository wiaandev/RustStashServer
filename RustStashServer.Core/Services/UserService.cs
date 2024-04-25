namespace RustStashServer.Core.Services
{
    using Microsoft.AspNetCore.Identity;
    using RustStashServer.Core.Entities.Auth;

    public class UserService
    {

        private readonly ILogger<UserService> logger;
        private readonly UserManager<User> userManager;

        public UserService(ILogger<UserService> logger, UserManager<User> userManager)
        {
            this.logger = logger;
            this.userManager = userManager;
        }

        public IQueryable<User> GetUsers(AppDbContext dbContext)
        {
            return dbContext.Users.AsQueryable();
        }
    }
}
