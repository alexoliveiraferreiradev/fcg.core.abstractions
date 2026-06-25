namespace Fcg.Core.Abstractions.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
    }
}
