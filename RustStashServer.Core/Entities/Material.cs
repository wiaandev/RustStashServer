using System.Collections;

namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Material
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaterialId { get; set; }

    public string MaterialImage { get; set; } = null!;

    public string MaterialDescription { get; set; } = null!;

    public bool MaterialIsCraftable { get; set; }

    public IList<MaterialCategory> MaterialCategories { get; set; } = null!;

    public IList<RecipeMaterial> RecipeMaterials { get; set; }

    public IList<UserStashMaterial> UserStashMaterials { get; set; }

}