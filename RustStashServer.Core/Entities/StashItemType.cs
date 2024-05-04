using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RustStashServer.Core.Entities;

public class StashItemType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StashItemTypeId { get; set; }

    public string StashItemTypeName { get; set; } = null!;
}