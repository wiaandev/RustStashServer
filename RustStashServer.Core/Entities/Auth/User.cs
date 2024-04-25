using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RustStashServer.Core.Entities.Auth
{
    public class User: IdentityUser<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;
        
        [ForeignKey(nameof(ProfilePicture))]
        public int ProfileImage { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
