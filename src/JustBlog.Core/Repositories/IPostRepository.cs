using JustBlog.Core.Domain.Content;
using JustBlog.Core.Models;
using JustBlog.Core.Models.Content;
using JustBlog.Core.SeedWorks;

namespace JustBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);

        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}