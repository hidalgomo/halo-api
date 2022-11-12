using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("Outreach")]
public partial class OutreachEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("OutreachID")]
    public int OutreachId { get; set; }
    public int? InteractionTypeId { get; set; }
    public int? InteractionReasonId { get; set; }

    public string Name { get; set; }
    public string Remarks { get; set; }
    public string Status { get; set; }

    public DateTime? ScheduledDate { get; set; }
}