

namespace AC3GUIProgram.Persistance.DAO
{
    public interface IDAO<T>
    {
        public T GetById<TId>(TId id);
        public IEnumerable<T> GetAll();
        public void Add(T entity);
        public void Add(IEnumerable<T> entities);
        public void Remove(T entity);
        public void Remove(IEnumerable<T> entities);
        public void Update(T entity);
    }
}
