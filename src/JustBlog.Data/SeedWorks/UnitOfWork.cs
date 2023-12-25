using JustBlog.Core.SeedWorks;

namespace JustBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogContext _context;

        public UnitOfWork(JustBlogContext context)
        {
            _context = context;
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