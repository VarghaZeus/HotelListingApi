namespace TermixListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task<T> AddAsync(T entity);
        Task<T> GetAsync(int? id);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
    }
}
