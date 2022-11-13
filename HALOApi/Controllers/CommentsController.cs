using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentService _commentService;

    public CommentsController(ICommentService commentService)
    {
        this._commentService = commentService;
    }

    [HttpGet("{ClientId}", Name = nameof(GetCommentsAsync))]
    public async Task<ActionResult<Collection<Comment>>> GetCommentsAsync(int ClientId)
    {
        IList<Comment> comments = await this._commentService.GetCommentsByClientIdAsync(ClientId);
        Collection<Comment> collection = new Collection<Comment>();
        collection.Data = comments.ToArray();

        return Ok(collection);
    }

    [HttpPost("{Comment}", Name = nameof(AddCommentAsync))]
    public async Task<ActionResult<Comment>> AddCommentAsync(Comment Comment)
    {
        await this._commentService.AddCommentToClientAsync(Comment);
        return Ok(Comment);
    }
}
