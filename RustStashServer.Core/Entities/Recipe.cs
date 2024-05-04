namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipe
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public IList<RecipeMaterial> RecipeMaterials { get; set; } = null;

    public Category? Category { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string RecipeImage { get; set; } = null!;

    public int RequiredBenchLevel { get; set; }
}