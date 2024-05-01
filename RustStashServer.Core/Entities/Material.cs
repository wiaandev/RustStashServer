namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Material
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaterialId { get; set; }

    public string? MaterialImage { get; set; } = null!;

    public string? MaterialDescription { get; set; } = null!;

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; } = null!;

    public int CategoryId { get; set; }

    public bool MaterialIsCraftable { get; set; }
}