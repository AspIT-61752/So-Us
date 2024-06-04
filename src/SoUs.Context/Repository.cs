namespace SoUs.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SoUsDbContext p_sosuContext;
        public Repository(SoUsDbContext sosuContext)
        {
            p_sosuContext = sosuContext;
        }

        // CRUD => Create, Read, Update, Delete
        public void Add(T entity)
        {
            p_sosuContext.Add(entity);
            p_sosuContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            p_sosuContext.Remove(entity);
            p_sosuContext.SaveChanges();
        }

        public void DeleteBy(int id)
        {
            T entity = GetBy(id);
            Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return p_sosuContext.Set<T>().ToList();
        }

        public virtual T GetBy(int id)
        {
            return p_sosuContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            p_sosuContext.Update(entity);
            p_sosuContext.SaveChanges();
        }
    }
}
