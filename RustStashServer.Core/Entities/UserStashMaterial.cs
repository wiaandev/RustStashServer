using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RustStashServer.Core.Entities.Auth;

namespace RustStashServer.Core.Entities;

public class UserStashMaterial
{

    public int UserStashMaterialOwnerId { get; set; }

    public User UserStashMaterialOwner { get; set; } = null!;

    public int MaterialIds { get; set; }

    public Material Material { get; set; } = null!;

    public int UserStashIds { get; set; }

    public UserStash UserStash { get; set; } = null!;
}