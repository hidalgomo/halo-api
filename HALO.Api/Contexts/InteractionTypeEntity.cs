using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("InteractionType")]
public partial class InteractionTypeEntity : InteractionEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("InteractionTypeId")]
    public int InteractionId { get; set; }
}