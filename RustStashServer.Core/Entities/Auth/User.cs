﻿namespace RustStashServer.Core.Entities.Auth;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        [ForeignKey(nameof(Image))]
        public int ProfileImage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool Deleted { get; set; }

        public int TotalItemsCrafted { get; set; }
    }

