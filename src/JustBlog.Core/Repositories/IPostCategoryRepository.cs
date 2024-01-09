using JustBlog.Core.Domain.Content;
using JustBlog.Core.Models;
using JustBlog.Core.Models.Content;
using JustBlog.Core.SeedWorks;

namespace JustBlog.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
    }
}