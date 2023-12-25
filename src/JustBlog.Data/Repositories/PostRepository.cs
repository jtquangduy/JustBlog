using JustBlog.Core.Domain.Content;
using JustBlog.Core.Repositories;
using JustBlog.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace JustBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(JustBlogContext context) : base(context)
        {
        }

        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}