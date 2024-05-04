namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class RecipeMaterial
{
    public int MaterialIds { get; set; }

    public Material Material { get; set; } = null!;

    public int RecipeIds { get; set; }

    public Recipe Recipe { get; set; } = null!;
}