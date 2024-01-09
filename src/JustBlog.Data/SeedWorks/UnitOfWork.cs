using AutoMapper;
using JustBlog.Core.Repositories;
using JustBlog.Core.SeedWorks;
using JustBlog.Data.Repositories;

namespace JustBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogContext _context;

        public IPostRepository Posts { get; private set; }

        public IPostCategoryRepository PostCategories { get; private set; }

        public UnitOfWork(JustBlogContext context, IMapper mapper)
        {
            _context = context;

            Posts = new PostRepository(context, mapper);

            PostCategories = new PostCategoryRepository(context, mapper);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}