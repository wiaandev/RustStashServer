namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipe
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecipeId { get; set; }

    public string? RecipeName { get; set; } = null!;

    [ForeignKey(nameof(RecipeIngredient))]
    public int RecipeIngredientId { get; set; }

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }

    public string? Description { get; set; } = null!;

    [ForeignKey(nameof(Image))]
    public int ImageId { get; set; }

    public int RequiredBenchLevel { get; set; }
}