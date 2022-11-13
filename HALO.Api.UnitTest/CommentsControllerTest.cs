using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class CommentsControllerTest
{
    [Fact]
    public async void GetCommentsAsync_ReturnsNonEmptyCol()
    {
        int clientId = 1234;
        Mock<ICommentService> mockedService = new Mock<ICommentService>();
        mockedService.Setup(x => x.GetCommentsByClientIdAsync(clientId)).ReturnsAsync( new Comment[] { new Comment() } );
        CommentsController controller = new CommentsController(mockedService.Object);

        ActionResult<Collection<Comment>> response = await controller.GetCommentsAsync(clientId);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Collection<Comment> collection = (Collection<Comment>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }

    [Fact]
    public async void AddCommentAsync_ReturnsComment()
    {
        Comment comment = new Comment { CommentId = 1234 };
        Mock<ICommentService> mockedService = new Mock<ICommentService>();
        mockedService.Setup(x => x.AddCommentToClientAsync( comment )).ReturnsAsync( comment );
        CommentsController controller = new CommentsController(mockedService.Object);

        ActionResult<Comment> response = await controller.AddCommentAsync(comment);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Comment returnedComment = (Comment) okObject.Value;

        Assert.IsType<Comment>(returnedComment);
    }
}