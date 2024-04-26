namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Base
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BaseId { get; set; }

    public string? Latitude { get; set; } = null!;

    public string? Longitude { get; set; } = null!;

    [ForeignKey("UserStashId")]
    public UserStash UserStash { get; set; } = null!;

    public int UserStashId { get; set; }
}