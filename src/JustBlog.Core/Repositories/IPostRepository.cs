using JustBlog.Core.Domain.Content;
using JustBlog.Core.SeedWorks;

namespace JustBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
    }
}