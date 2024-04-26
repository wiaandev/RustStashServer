namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RustStashServer.Core.Entities.Auth;


public class UserStash
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserStashId { get; set; }

    [ForeignKey("MaterialId")]
    public Material? Material { get; set; } = null;

    public int MaterialId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; } = null;

    public int UserId { get; set; }

    public int? Quantity { get; set; } = null!;

    [ForeignKey("BaseId")]
    public Base? Base { get; set; } = null!;

    public int BaseId { get; set; }
}