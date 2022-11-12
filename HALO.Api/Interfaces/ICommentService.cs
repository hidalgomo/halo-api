using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface ICommentService
{
    Task<IList<Comment>> GetCommentsByClientIdAsync(int ClientId);
    Task<Comment> AddCommentToClientAsync(Comment Comment);
}