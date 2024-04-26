namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class RecipeIngredient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecipeIngredientId { get; set; }

    [ForeignKey("MaterialId")]
    public Material? Material { get; set; } = null!;

    public int MaterialId { get; set; }

    public int RequiredQuantity { get; set; }
}