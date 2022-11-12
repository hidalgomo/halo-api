using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("InteractionReason")]
public partial class InteractionReasonEntity : InteractionEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("InteractionReasonId")]
    public int InteractionId { get; set; }
}