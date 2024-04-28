using RustStashServer.Core.Services.Inputs;

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

        public async Task<User> Create(AppDbContext dbContext, CreateUserInput input)
        {
            if (input.UserInput is null)
            {
                throw new Exception("User Details are required");
            }


            var email = input.UserInput.Email;
            var username = input.UserInput.Username;
            var dob = input.UserInput.DateOfBirth;
            var profilePicture = input.UserInput.ProfilePicture;

            var user = new User
            {
                UserName = username,
                // EmailConfirmed = false,
                // PasswordHash = null,
                // SecurityStamp = null,
                // ConcurrencyStamp = null,
                // PhoneNumber = null,
                // PhoneNumberConfirmed = false,
                // TwoFactorEnabled = false,
                // LockoutEnd = null,
                // LockoutEnabled = false,
                // AccessFailedCount = 0,
                // UserId = 0,
                Username = username,
                Email = email,
                ProfileImage = profilePicture,
                CreatedAt = DateTime.Now,
                DateOfBirth = dob
            };

            await this.userManager.CreateAsync(user);
            await this.userManager.AddToRoleAsync(user, input.Role);

            await dbContext.SaveChangesAsync();
            return user;
        }
        
        
    }
}
