namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipe
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecipeId { get; set; }

    public string? RecipeName { get; set; }

    [ForeignKey("RecipeIngredientId")]
    public RecipeIngredient? RecipeIngredient { get; set; } = null;

    public int RecipeIngredientId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    [ForeignKey("ImageId")]
    public Image? Image { get; set; } = null;

    public int ImageId { get; set; }

    public int RequiredBenchLevel { get; set; }
}