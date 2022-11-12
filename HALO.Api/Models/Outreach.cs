namespace HALO.Api.Models;

public class Outreach
{
    public int OutreachId { get; set; }

    public int? Count { get; set; }
    public int? InteractionTypeId { get; set; }
    public int? InteractionReasonId { get; set; }

    public DateTime? ScheduledDate { get; set; }

    public IList<int> ClientIdsToOutreach { get; set; }
}