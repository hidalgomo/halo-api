using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("InteractionOutcome")]
public partial class InteractionOutcomeEntity : InteractionEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("InteractionOutcomeId")]
    public int InteractionId { get; set; }
}