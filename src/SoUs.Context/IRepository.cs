namespace SoUs.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteBy(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }
}
