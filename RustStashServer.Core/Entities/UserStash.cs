namespace RustStashServer.Core.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RustStashServer.Core.Entities.Auth;


public class UserStash
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserStashId { get; set; }

    public Base Base { get; set; } = null!;

    public StashItemType StashItemType { get; set; } = null!;

    public IList<UserStashMaterial> UserStashMaterials { get; set; }
}