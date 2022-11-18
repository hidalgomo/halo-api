namespace HALO.Api.Models.Person;

public class User : BasePerson
{
    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public string UserName { get; set; }
}
