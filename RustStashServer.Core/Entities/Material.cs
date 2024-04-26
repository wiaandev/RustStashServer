namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Material
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaterialId { get; set; }

    [ForeignKey(nameof(Image))]
    public int ImageId { get; set; }

    public string? MaterialDescription { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }

    public bool MaterialIsCraftable { get; set; }

    [ForeignKey(nameof(Material))]
    public List<int>? ItemsUsedToCraftId { get; set; }
}