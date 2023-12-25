namespace JustBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
    }
}