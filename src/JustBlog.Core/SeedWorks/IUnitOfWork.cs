using JustBlog.Core.Repositories;

namespace JustBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }

        IPostCategoryRepository PostCategories { get; }

        Task<int> CompleteAsync();
    }
}