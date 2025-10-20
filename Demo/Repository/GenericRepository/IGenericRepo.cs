namespace Demo.Repository.GenericRepository
{
    public interface IGenericRepo<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
