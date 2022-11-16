namespace HALO.Api.Models;

public class CaresCase : Case
{
    public int? HocCaresId  { get; set; }

    public string CARESiD       { get; set; }
    public string CaseType      { get; set; }
    public string ExitReason    { get; set; }

    public DateTime? ExitDate       { get; set; }
    public DateTime? CheckInDate    { get; set; }
    public DateTime? CheckOutDate   { get; set; }
}