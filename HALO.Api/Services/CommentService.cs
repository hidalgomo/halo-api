using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class CommentService : ICommentService
{
    private readonly HALOdB _database;

    public CommentService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<Comment>> GetCommentsByClientIdAsync(int ClientId)
    {
        return await this._database.Comments
            .Where(x => x.ClientId == ClientId)
            .Select(x => new Comment
            {
                CommentId = x.CommentId,
                ClientId = x.ClientId
            })
            .ToListAsync();
    }

    public async Task<Comment> AddCommentToClientAsync(Comment Comment)
    {
        CommentEntity commentEntity = new CommentEntity();
        commentEntity.ClientId = Comment.ClientId;
        commentEntity.Body = Comment.Body;

        await this._database.Comments.AddAsync( commentEntity );
        await this._database.SaveChangesAsync();

        Comment.CommentId =  commentEntity.CommentId;
        return Comment;
    }
}