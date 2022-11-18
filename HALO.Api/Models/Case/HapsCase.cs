namespace HALO.Api.Models.Case;

public class HapsCase : BaseCase
{
    public bool? IRSVerified { get; set; }
    public bool? LldEftInd { get; set; }
    
    public decimal? PaymentAmount { get; set; }
    public decimal? HouseholdSizeMaxRent { get; set; }
    public decimal? SpecialSubsidy { get; set; }
    public decimal? StandardSubsidy { get; set; }
    public decimal? EnhancedSubsidy { get; set; }
    public decimal? NpaContribution { get; set; }
    public decimal? ShelterAllowance { get; set; }
    public decimal? MonthlyRent { get; set; }
    public decimal? ClientContribution { get; set; }
    public decimal? MonthlyCityShareOfRent { get; set; }

    public DateTime? LeaseSign { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? LeaseFrom { get; set; }
    public DateTime? LeaseTo { get; set; }
    public DateTime? ModDte { get; set; }
    public DateTime? PaymentFrom { get; set; }
    public DateTime? PaymentTo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ApartmentNumber { get; set; }
    public string ApartmentAddress { get; set; }
    public string ApartmentBoro { get; set; }
    public string ApartmentZip { get; set; }
    public string ClientSSN { get; set; }
    public string ClientPhone { get; set; }
    public string ClientAltPhone { get; set; }
    public string ClientEmgPhone { get; set; }
    public string PrgInd { get; set; }
    public string PaUserComment { get; set; }        
    public string SiUserComment { get; set; }
    public string SourceInd { get; set; }
    public string LldTin { get; set; }
    public string LldLegalName { get; set; }
    public string LldUnitNumber { get; set; }
    public string LldAddress { get; set; }
    public string LldCity { get; set; }
    public string LldState { get; set; }
    public string LldZip { get; set; }
    public string LldTinType { get; set; }
    public string LldFirstName { get; set; }
    public string LldLastName { get; set; }
    public string LldPhone { get; set; }
    public string LldAltPhone { get; set; }
    public string LldEmail { get; set; }
    public string LldRouting { get; set; }
    public string LldAccount { get; set; }
    public string PrgProvider { get; set; }
    public string HousingType { get; set; }
    public string FinTin { get; set; }
    public string FinTinType { get; set; }
    public string FinLegalName { get; set; }
    public string FinFirstName { get; set; }
    public string FinLastName { get; set; }
    public string FinAddress { get; set; }
    public string FinUnitNumber { get; set; }
    public string FinCity { get; set; }
    public string FinState { get; set; }
    public string FinZip { get; set; }
    public string FinEmail { get; set; }
    public string FinPhone { get; set; }
    public string Status { get; set; }
    public string HpdMidInc { get; set; }
    public string PayeeSourceId { get; set; }
}