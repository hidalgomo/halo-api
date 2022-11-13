using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("Placement_Fct", Schema = "cares")]
public partial class CarescaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SYS_Placement_ID")]
    public int PlacementId { get; set; }

    [Column("CARES_ID")]
    public int? CARESiD { get; set; }

    [Column("Case_ID")]
    public Int64? CaseId { get; set; }

    [Column("Case_Number")]
    public int? CaseNumber { get; set; }

    [Column("Case_Type")]
    public string CaseType { get; set; }

    [Column("CheckIn_DTTM")]
    public DateTime? CheckInDate { get; set; }

    [Column("CheckOut_DTTM")]
    public DateTime? CheckOutDate { get; set; }

    [Column("CL_Last_Written_DTTM")]
    public DateTime? ClLastWrittenDate { get; set; }

    [Column("Client_Latest_Placement_FLG")]
    public string ClientLatestPlacementFlag { get; set; }

    [Column("Date_of_Birth")]
    public DateTime? DOB { get; set; }

    [Column("Disallowed_Reason")]
    public string DisallowedReason { get; set; }

    [Column("Exit_Category")]
    public string ExitCategory { get; set; }

    [Column("Exit_DTTM")]
    public DateTime? ExitDate { get; set; }

    [Column("Exit_Reason")]
    public string ExitReason { get; set; }

    [Column("Facility_Class")]
    public string FacilityClass { get; set; }

    [Column("Facility_Name")]
    public string FacilityName { get; set; }

    [Column("Facility_Type")]
    public string FacilityType { get; set; }

    [Column("Gender")]
    public string Gender { get; set; }

    [Column("HOC_CARES_ID")]
    public int? HocCaresId { get; set; }

    [Column("Origin_Date")]
    public DateTime? OriginDate { get; set; }

    [Column("Placement_End_DTTM")]
    public DateTime? PlacementEndDttm { get; set; }

    [Column("Placement_Outcome")]
    public string PlacementOutcome { get; set; }

    [Column("Placement_Start_DTTM")]
    public DateTime? PlacementStartDate { get; set; }

    [Column("Shelter_Assignment_Type")]
    public string ShelterAssignmentType { get; set; }

    [Column("UBPL_Last_Written_DTTM")]
    public DateTime? UbplLastWrittenDate { get; set; }

    [Column("Unitbed_Assignment_Status")]
    public string UnitbedAssignmentStatus { get; set; }

    [Column("DM_Create_DTTM")]
    public DateTime? DmCreateDate { get; set; }

    [Column("DM_Update_DTTM")]
    public DateTime? DmUpdateDate { get; set; }
}