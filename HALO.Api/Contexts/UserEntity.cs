using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HALO.Api.Contexts;

[Table("User")]
public partial class UserEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public string UserName      { get; set; }
    public string FirstName     { get; set; }
    public string LastName      { get; set; }
}
