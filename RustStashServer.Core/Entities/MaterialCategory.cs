namespace RustStashServer.Core.Entities;

public class MaterialCategory
{
    public int MaterialIds { get; set; }

    public Material Material { get; set; }

    public int CategoryIds { get; set; }

    public Category Category { get; set; }
}