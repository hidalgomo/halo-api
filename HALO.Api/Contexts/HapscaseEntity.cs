using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("HAPSLeasing")]
public partial class HapsCaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("PR_ID")]
    public int PrId { get; set; }

    [Column("PA_NUMBER")]
    public string PaNumber { get; set; }

    [Column("MOD_DTE")]
    public DateTime? ModDate { get; set; }
}