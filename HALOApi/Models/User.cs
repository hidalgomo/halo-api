namespace HALO.Api.Models;

public class User : Person
{
    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public string UserName { get; set; }
}
