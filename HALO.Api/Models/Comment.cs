namespace HALO.Api.Models;

public class Comment
{
    public int CommentId { get; set; }
    public int ClientId { get; set; }

    public string Body { get; set; }
}