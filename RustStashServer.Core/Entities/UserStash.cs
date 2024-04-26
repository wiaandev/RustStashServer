namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RustStashServer.Core.Entities.Auth;


public class UserStash
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserStashId { get; set; }

    [ForeignKey(nameof(Material))]
    public int MaterialId { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }

    public int? Quantity { get; set; } = null!;

    [ForeignKey(nameof(Base))]
    public int BaseId { get; set; }
}