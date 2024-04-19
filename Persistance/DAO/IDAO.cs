

namespace AC3GUIProgram.Persistance.DAO
{
    public interface IDAO
    {
        IDAO GetById<T>(T id);
        public IEnumerable<IDAO> GetAll();
        public void Add(IDAO entity);
        public void Add(IEnumerable<IDAO> entities);
        public void Remove(IDAO entity);
        public void Remove(IEnumerable<IDAO> entities);
        public void Update(IDAO entity);
    }
}
